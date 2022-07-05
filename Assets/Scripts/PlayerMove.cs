using System;
using DefaultNamespace.Abstract;
using Interfaces;
using UnityEngine;

namespace DefaultNamespace
{
    public class PlayerMove : PlayerMoveStandart, IPlayerMoveController
    {
        private float _horizontal;
        
        private float _vertical;

        private Vector3 _playerMovement;
        
        private void Awake()
        {
            StandartRigidbody = GetComponent<Rigidbody>();
        }

        private void OnTriggerEnter(Collider other)
        {
            throw new NotImplementedException();
        }

        public void Move()
        {
            _horizontal = Input.GetAxis("Horizontal");
            _vertical = Input.GetAxis("Vertical");

            _playerMovement = new Vector3(_horizontal, 0f, _vertical);
            
            StandartRigidbody.AddForce(_playerMovement * Speed);
        }
        
    }
}