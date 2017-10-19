using System;
using Common;
using Agent.Implementations;
namespace Agent
{
    public abstract class Agent : IAgent
    {
        public enAgentType Type { get; set; }
    }


    //command pattern
    public abstract class NotifyDataChanged : Operation<Agent>
    {
        public NotifyDataChanged(Agent agent) : base(agent)
        {

        }

        public override void Execute()
        {

        }
    }

    //command pattern
    public abstract class PullChangedData : Operation<Agent>
    {
        public PullChangedData(Agent agent) : base(agent)
        {

        }

        public override void Execute()
        {

        }
    }

}
