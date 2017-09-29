using System;

namespace Agent
{
    public abstract class Agent<T> : IAgentOperations where T : IDataProvider
    {
        public void FileSystemChanged()
        {
            throw new NotImplementedException();
        }

        public object SetupWatcher()
        {
            throw new NotImplementedException();
        }
    }

    public interface IAgentOperations
    {
        Object SetupWatcher();
        void FileSystemChanged();
    }

    public interface IDataProvider
    {
        
    }

    public abstract class DataProvider:IDataProvider
    {
        
    }

}
