using RVO;
using UnityEngine;
using Vector2 = UnityEngine.Vector2;
namespace Mono.Unit
{
    public class PathFindingAgent : MonoBehaviour
    {
        [SerializeField] private CharacterController characterController;
        public Vector3 targetPosition;
        public Vector3 preferredVelocity;
        private Agent rvoAgent;

        public void SetAgent(Agent agent)
        {
            rvoAgent = agent;
        }
        public void SetVelocity(Vector3 velocity)
        {
            characterController.Move(velocity);
        }
    }
}