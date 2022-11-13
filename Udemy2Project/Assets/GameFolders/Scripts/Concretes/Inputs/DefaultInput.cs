using System.Collections;
using System.Collections.Generic;
using Udemy1Project.Inputs;
using UnityEngine;
using static UnityEditor.Timeline.TimelinePlaybackControls;


namespace Udemy2Project.Inputs
{
   public class DefaultInput 
   {
        

       private DefaultAction _input;
       public bool IsForceUp { get; private set; }

       public bool LeftRight { get; private set; } 

        public DefaultInput ()
       {
            
           _input = new DefaultAction ();  

           _input.Rocket.ForceUp.performed += context => IsForceUp = context.ReadValueAsButton ();

           _input.Enable();


            
       }





        
  }
}

