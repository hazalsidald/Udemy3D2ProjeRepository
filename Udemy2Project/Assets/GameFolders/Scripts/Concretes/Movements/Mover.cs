using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Udemy2Project.Movements
{
    public class Mover
    {
        Rigidbody _rigidbody;

        public Mover (Rigidbody rigidbody)
        {
            _rigidbody = rigidbody;
        }   
       public void FixedTick()
        {
            _rigidbody.AddRelativeForce(Vector3.up * Time.deltaTime * 60f);

            
        }






    }
}
