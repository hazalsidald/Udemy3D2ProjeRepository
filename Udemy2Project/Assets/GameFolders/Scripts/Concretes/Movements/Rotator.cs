using System.Collections;
using System.Collections.Generic;
using Udemy2Project.Controllers;
using UnityEngine;

namespace Udemy2Project.Movements
{
    public class Rotator 
    {
        Rigidbody _rigidbody;
        PlayerController _playerController;

        public Rotator (PlayerController playerController)
        {
            _playerController = playerController;   
            _rigidbody = playerController.GetComponent<Rigidbody>();
        }

        public void FixedTick(float direction)
        {

            
        }












    }

}
