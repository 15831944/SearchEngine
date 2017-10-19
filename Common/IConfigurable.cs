using System;
namespace Common
{
    public interface IConfigurable<T> where T : IBaseObject
    {

        object _storedConfiguration { get; set; }
        ICommand UpdateConfiguration { get; set; }
        string _displayConfiguration();
    }
}
