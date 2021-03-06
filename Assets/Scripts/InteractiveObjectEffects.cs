using DefaultNamespace.Enums;
using UnityEngine;
using static UnityEngine.Debug;

namespace DefaultNamespace
{
    public class InteractiveObjectEffects : MonoBehaviour
    {
        public void UseBaff(GameObject obj, BaffType type, float value)
        {
            Log("Used Baff");
            switch (type)
            {
                case BaffType.ExtraHealth:
                    ExtraHealth(obj, value);
                    break;
                case BaffType.ExtraSpeed:
                    ExtraSpeed(obj, value);
                    break;
            }
        }

        public void UseDebaff(GameObject obj, DebaffType type, float value)
        {
            Log("Used Debaff");
            switch (type)
            {
                case DebaffType.LowHealth:
                    LowHealth();
                    break;
                case DebaffType.LowSpeed:
                    LowSpeed();
                    break;
            }
        }

        public void UseTrap(GameObject obj, TrapType type, float value)
        {
            Log("Used Trap");
            switch (type)
            {
                case TrapType.Damage:
                    Damage();
                    break;
                case TrapType.Death:
                    Death();
                    break;
            }
        }

        //=============================== BAFFS
        private void WinBaffAdd(GameObject obj)
        {
            
        }
        private void ExtraHealth(GameObject obj, float value)
        {
            obj.GetComponent<Health>().AddHealth(value);
        }

        private void ExtraSpeed(GameObject obj, float value)
        {
            // TODO
        }

        //================================ DEBAFFS
        private void LowHealth()
        {
            // TODO
        }

        private void LowSpeed()
        {
            // TODO
        }

        //================================ TRAPS
        private void Death()
        {
            // TODO
        }

        private void Damage()
        {
            // TODO
        }
    }
}