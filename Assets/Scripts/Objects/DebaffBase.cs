using DefaultNamespace.Abstract;
using DefaultNamespace.Enums;
using UnityEngine;

namespace DefaultNamespace.Objects
{
    public class DebaffBase : InteractiveObject
    {
        [SerializeField]
        private DebaffType _type;

        protected override void TriggerAccept(GameObject obj)
        {
            var debaff = new BaffEffects();
            debaff.UseDebaff(obj, _type, _value);

            if (!_reusable)
                RemoveBaff();
        }

        private void RemoveBaff()
        {
            print("Baff Removed!");
            Destroy(gameObject);
        }
    }
}