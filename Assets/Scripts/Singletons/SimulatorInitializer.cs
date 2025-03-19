using System;
using System.Collections.Generic;
using RVO;
using UnityEngine;
using Vector2 = RVO.Vector2;

namespace Singletons
{
    [Serializable]
    public class SimulatorInitializer
    {
        [Serializable]
        public class SimulatorSettings
        {
            public InitUnitConfig unitConfig;
            public float neighborDist;
            public int maxNeighbors;
            public float timeHorizon;
            public float timeHorizonObst;
            public float radius;
            public float maxSpeed;
            public UnityEngine.Vector2 velocity;
        }
        public static SimulatorInitializer Instance;
        public Simulator simulator;
        private InitUnitConfig unitConfig;
        
        private List<GameObject> agents;
        public SimulatorInitializer(SimulatorSettings settings)
        {
            if (Instance == null)
                Instance = this;
            simulator = new Simulator();
            unitConfig = settings.unitConfig;
            simulator.setAgentDefaults(settings.neighborDist, settings.maxNeighbors,settings.timeHorizon, 
                                    settings.timeHorizonObst, settings.radius, settings.maxSpeed
                                , new Vector2(settings.velocity.x, settings.velocity.y));
            foreach (var u_agent in unitConfig.Agents)
            {
                RVO.Vector2 v = new RVO.Vector2(u_agent.position.x, u_agent.position.z);
                int agentID = simulator.addAgent(v);
                Agent agent = simulator.agents_[agentID];
                GameObject unit = GameObject.Instantiate(u_agent.prefab, u_agent.position, u_agent.rotation);
                //TODO:将unit中的agent变量赋值，unit监听agent的事件
            }
        }
    }
}