using UnityEngine;

namespace DefaultNamespace.Abstract
{
    [RequireComponent(typeof(Rigidbody))]
    public abstract class PlayerMoveStandart : MonoBehaviour
    {
        protected float Speed;
        
        protected Rigidbody StandartRigidbody;

        public float GetSpeed()
        {
            return Speed; // GetSpeed => Speed, not worked with IPlayerMoveController, i down know why.
        }
        
        /// <summary>
        /// set speed, type Speed = speed;
        /// </summary>
        /// <param name="speed"></param>
        public void SetSpeed(float speed)
        {
            Speed = speed;
        }
        
        /// <summary>
        /// add speed, type Speed += speed
        /// if you need to set speed, use SetSpeed(float);
        /// </summary>
        /// <param name="speed"></param>
        public void AddSpeed(float speed)
        {
            Speed += speed;
        }
    }
}