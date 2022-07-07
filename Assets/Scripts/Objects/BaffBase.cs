using System.Collections;
using System.Collections.Generic;
using DefaultNamespace.Abstract;
using DefaultNamespace.Enums;
using UnityEngine;

public class BaffBase : InteractiveObject
{
    [SerializeField]
    private BaffType _type;

    [SerializeField]
    private float _value;

    [SerializeField]
    private bool _reusable;

    protected override void TriggerAccept(GameObject obj)
    {
        Use(obj);
        if (_reusable)
        {
            RemoveBaff();
        }
    }


    private void Use(GameObject obj)
    {
        switch (_type)
        {
            case BaffType.ExtraHealth:
                break;
            case BaffType.ExtraSpeed:
                break;
            default: break;
        }
    }

    private void ExtraHealth(GameObject obj)
    {
        obj.GetComponent<Health>().AddHealth(_value);
    }

    private void RemoveBaff()
    {
        print("Baff Removed!");
        Destroy(gameObject);
    }
}