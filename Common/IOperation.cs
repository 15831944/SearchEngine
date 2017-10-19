using System;
namespace Common
{
    public interface IOperation:ITransaction, IObservable
    {
        Guid ID { get; set; }
    }

    //can determine the generic interface at runtime
    public interface IOperationWithResult<T>:IOperation {}

    public abstract class Operation<T> :IOperation
    {
        public bool IsCompleted { get; set; }

        public Guid ID { get ; set; }

        protected T _scopeInstance;

        public abstract void Execute();

        public Operation(T scopeInstance)
        {
            _scopeInstance = scopeInstance;
        }
    }

    public interface IOperationOptions
    {
        IBaseObject Result { get; set; }
    }

    public enum enOperationResult
    {
        Success = 1,
        Fail=2
    }
}
