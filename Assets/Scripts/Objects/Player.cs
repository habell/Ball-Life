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

    private IPlayerMoveController _playerMoveController;

    private void Awake()
    {
        StartGame();
    }

    private void StartGame()
    {
        _playerMoveController ??= GetComponent<IPlayerMoveController>();
        _playerMoveController.SetSpeed(_speed);
    }

    private void FixedUpdate()
    {
        _playerMoveController.Move();
    }
}
