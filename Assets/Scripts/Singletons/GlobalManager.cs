using UnityEngine;

namespace Singletons
{
    public class GlobalManager : MonoBehaviour
    {
        [SerializeField] private SimulatorInitializer.SimulatorSettings simulatorSettings;
        private SimulatorInitializer simulatorInitializer;

        void Awake()
        {
            simulatorInitializer = new SimulatorInitializer(simulatorSettings);
        }
    }
}