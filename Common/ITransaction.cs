using System;
namespace Common
{
    public interface ITransaction
    {
        bool IsCompleted { get; set; }
        void Execute();
    }
}
