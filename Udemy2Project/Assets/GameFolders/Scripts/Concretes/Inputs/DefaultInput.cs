using System.Collections;
using System.Collections.Generic;
using Udemy1Project.Inputs;
using UnityEngine;

namespace Udemy2Project.Inputs
{
    public class DefaultInput //normal bir class monobehavior gerek yok.
    {
        private DefaultAction _input;
        public bool IsForceUp { get; private set; }
        public DefaultInput()
        {
            _input = new DefaultAction();
           _input.Rocket.ForceUp.performed += context => IsForceUp = context.ReadValueAsButton();   
        }

        
            
        
    }

}
