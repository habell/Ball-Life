using System.Collections;
using System.Collections.Generic;
using DefaultNamespace.Abstract;
using DefaultNamespace.Enums;
using UnityEngine;

public class BaffBase : InteractiveObject
{
    [SerializeField]
    private BaffType _baffType;
    protected override void TriggerAccept(GameObject obj)
    {
        throw new System.NotImplementedException();
    }
}
