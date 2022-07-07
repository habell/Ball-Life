using System;
using DefaultNamespace.Enums;
using Unity.VisualScripting;
using UnityEngine;
using Object = UnityEngine.Object;

namespace DefaultNamespace.Abstract
{
    [RequireComponent(typeof(Collider))]
    public abstract class InteractiveObject : MonoBehaviour
    {
        [SerializeField]
        private InteractiveObjectType _objectType;

        public InteractiveObjectType ObjectType => _objectType;


        [SerializeField]
        protected InteractiveObjectType[] _canAllowsTrigger;

        private void Awake()
        {
            if (GetComponents<Collider>().Length > 1)
            {
                bool haveTrigger = false;
                foreach (var collider in GetComponents<Collider>())
                {
                    if (collider.isTrigger)
                    {
                        haveTrigger = true;
                        break;
                    }
                }

                if (!haveTrigger)
                {
                    GetComponent<Collider>().isTrigger = true;
                    Debug.LogWarning(
                        "You have two colliders at your facility, but neither of them are triggers! " +
                        "We automatically set the first collider's isTrigger value to true. " +
                        "However, please check your interactive objects on stage!"
                    );
                }
            }
            else
            {
                if(!GetComponent<Collider>().isTrigger) GetComponent<Collider>().isTrigger = true;
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out InteractiveObject interactiveObject))
            {
                foreach (var objectType in _canAllowsTrigger)
                {
                    if (interactiveObject.ObjectType == objectType)
                    {
                        TriggerAccept(other.gameObject);
                    }
                }
            }
        }

        protected abstract void TriggerAccept(GameObject obj);
    }
}