using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
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
        var baff = new BaffEffects();
        baff.UseBaff(obj, _type, _value);
        
        if (!_reusable)
            RemoveBaff();
    }

    private void RemoveBaff()
    {
        print("Baff Removed!");
        Destroy(gameObject);
    }
}