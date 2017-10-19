using System;
using System.Collections.Generic;
using Common;

namespace Configurable
{
    public abstract class Configurable<T> : IConfigurable<T> where T:IBaseObject
    {
        public object _storedConfiguration { get; set; }
        public ICommand UpdateConfiguration { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string _displayConfiguration()
        {
            throw new NotImplementedException();
        }

        public Configurable()
        {
            
        }
    }

    public class UpdateConfigurationCommand : ICommand
    {
        public IList<IOperation> Operations { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsCompleted { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
