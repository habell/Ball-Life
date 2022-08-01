using System;
using System.Collections;
using System.Collections.Generic;
using Interfaces;
using UnityEngine;

[RequireComponent(typeof(IPlayerMoveController))]
public class Player : MonoBehaviour
{
    [SerializeField]
    private float _speed;
    
    [SerializeField]
    private int _winBaffsNeed;
    private int _winBaffsCount;

    private Health _health;
    
    private IPlayerMoveController _playerMoveController;
    
    public int WinBaffsCount
    {
        get => _winBaffsCount;
        set
        {
            _winBaffsCount = value;
            if (_winBaffsCount >= _winBaffsNeed)
            {
                //TODO: WIN FUNC
            }
        }
    }

    private void Awake()
    {
        StartGame();
    }

    private void StartGame()
    {
        _playerMoveController ??= GetComponent<IPlayerMoveController>();
        _playerMoveController.SetSpeed(_speed);
        _health = GetComponent<Health>();
    }

    private void FixedUpdate()
    {
        _playerMoveController.Move();
    }

    public void AddHealth(float extraHealth)
    {
        _health.AddHealth(extraHealth);
    }
    public void AddWinCount(int value)
    {
        print("Player added WinBaffWalue!");
        WinBaffsCount += value;
    }
}