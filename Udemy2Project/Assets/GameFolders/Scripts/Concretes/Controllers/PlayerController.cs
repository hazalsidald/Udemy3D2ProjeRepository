using System.Collections;
using System.Collections.Generic;
using Udemy2Project.Inputs;
using UnityEngine;
using System;
using Udemy2Project.Movements;


 namespace Udemy2Project.Controllers //namespace classlarý birbirinden ayirma yöntemidi.namespaceler proje adý ve dosya adýyla olur.
{
    public class PlayerController : MonoBehaviour
    { 

        DefaultInput _input;

        Mover _mover;

        float _leftRight;

        bool _isForceUp;
            


        private void Awake()

        {
          
            _input = new DefaultInput();
            _mover = new Mover(rigidbody:GetComponent<Rigidbody>());
            
        }


        private void Update()

        {
           

            if(_input.IsForceUp)
            {
                _isForceUp=true;    
            }
            else
            {
                _isForceUp = false;
            }

            
        }


        private void FixedUpdate()
        {
            if(_isForceUp)
            {
                
                _mover.FixedTick();
            }



        }
    }

}

