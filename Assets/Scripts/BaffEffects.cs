using DefaultNamespace.Enums;
using UnityEngine;
using UnityEngine.Android;

namespace DefaultNamespace
{
    public class BaffEffects : MonoBehaviour
    {
        public void UseBaff(GameObject obj, BaffType type, float value)
        {
            switch (type)
            {
                case BaffType.ExtraHealth:
                    ExtraHealth(obj, value);
                    break;
                case BaffType.ExtraSpeed:
                    ExtraSpeed(obj, value);
                    break;
                default: break;
            }
        }
        
        private void ExtraHealth(GameObject obj, float value)
        {
            obj.GetComponent<Health>().AddHealth(value);
        }
        
        private void ExtraSpeed(GameObject obj, float value)
        {
            // TODO
        }
    }
}