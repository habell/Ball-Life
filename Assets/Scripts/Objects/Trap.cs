using DefaultNamespace.Abstract;
using DefaultNamespace.Enums;
using UnityEngine;

namespace DefaultNamespace.Objects
{
    public class Trap : InteractiveObject
    {
        [SerializeField]
        private TrapType _type;
        
        protected override void TriggerAccept(GameObject obj)
        {
            throw new System.NotImplementedException();
        }
    }
}