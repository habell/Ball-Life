using System;
using DefaultNamespace.Enums;
using Unity.VisualScripting;
using UnityEngine;

namespace DefaultNamespace.Abstract
{
    public abstract class InteractiveObject : MonoBehaviour
    {
        [SerializeField]
        private InteractiveObjectType _objectType;
        

        [SerializeField]
        protected InteractiveObjectType[] _canAllowsTrigger;
        
        private void OnTriggerEnter(Collider other)
        {
            throw new NotImplementedException();
        }
    }
}