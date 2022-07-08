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
            var trap = new InteractiveObjectEffects();
            trap.UseTrap(obj, _type, _value);

            if (!_reusable)
                RemoveBaff();
        }

        private void RemoveBaff()
        {
            print("Trap Removed!");
            Destroy(gameObject);
        }
    }
}