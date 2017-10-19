using System;
using System.Collections.Generic;

namespace Common
{
    // a received command translates into one or multiple operations
    public interface ICommand:ITransaction 
    {
        IList<IOperation> Operations { get; set; }
    }

    public interface ICommandOptions
    {
        //execute operations in a transaction, restart if one failed
        bool Atomic { get; set; }
        bool Cancelable { get; set; }
    }
}
