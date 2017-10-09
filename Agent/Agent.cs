using System;
using Common;
using Agent.Implementations;
namespace Agent
{
    public abstract class Agent : IAgent
    {
        public enAgentType Type { get; set; }
    }

    public abstract class AgentOperation : IOperation
    {
        public bool IsCompleted { get; set; }
        Agent _agent;

        public abstract void Execute();

        public AgentOperation(Agent agent)
        {
            _agent = agent;
        }
    }

    public abstract class NotifyDataChanged : AgentOperation
    {
        public NotifyDataChanged(Agent agent) : base(agent)
        {

        }

        public override void Execute()
        {

        }
    }

    public abstract class PullChangedData : AgentOperation
    {
        public PullChangedData(Agent agent) : base(agent)
        {

        }

        public override void Execute()
        {

        }
    }

}
