using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField]
    private float _value;

    public float Value
    {
        get => _value;
        set
        {
            _value = value;
            if (_value <= 0)
            {
                Death();
            }
        }
    }

    public void AddHealth(float extraHealth)
    {
        _value += extraHealth;
    }

    private void Death()
    {
        throw new System.NotImplementedException();
    }
}