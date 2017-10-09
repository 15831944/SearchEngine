using System;
namespace Common
{
    public interface IRepository { }

    public interface IRepositoryConfiguration:IConfiguration 
    {
        enRepositoryType Type { get; }     
    }

    public enum enRepositoryType
    {
        Lucene=1,
        SQL=2,
        MongoDB=3
    }

}
