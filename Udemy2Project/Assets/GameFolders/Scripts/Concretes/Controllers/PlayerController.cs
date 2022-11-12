using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Udemy2Project.Controller
{
    public class PlayerController : MonoBehaviour
    {

        Rigidbody _rigidbody;

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }
        private void Update()
        {
            
        }

        private void FixedUpdate()
        {
            _rigidbody.AddForce(Vector3.up * Time.deltaTime);
        }
    }
}


