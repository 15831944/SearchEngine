using System;
namespace Common
{
	public interface IAgent	
    {
        enAgentType Type { get; }
    }

    public interface IAgentConfiguration:IConfiguration
    {
        
    }
        
    public enum enAgentType
    {
        Synergy=1,
        FileSystem=2,
        SharePoint=3,
        SQLServer=4
    }
}
