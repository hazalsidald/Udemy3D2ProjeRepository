using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//name spaceler proje ad� ve//dosya ad� al�r.
namespace Udemy2Project.Controllers//name spacelerin g�revi classlar�m�z� birbirinden ay�rmakt�r.
{
    public class PlayerController : MonoBehaviour
    {
      

        Rigidbody _rigidbody; //rigidbody fieldi
        Default _input;
        bool _isForceUp;

        private void Awake() //ke�ledim
        {
            _input = new
            _rigidbody = GetComponent<Rigidbody>(); //playerdaki rigidbady referans�n� buraya al�r.yani eri�ebilirim.
        }
        private void Update() //update ile �nputlar� al�r�z.�rne�in klavye bas�cam bir veri var bu veriyi update ile al�r�m.
        {                     // her bir fireymde bir �al���r, 1 sn 30 60 120 �al���r.
            
        }

        private void FixedUpdate()//fizik i�lemleri yapar�m �rnegin:rigidbady ,vollidor�n caprmas� , y�r�me
                                     //standartt�r 0.2 sn �eklinde �al���r. ve fizik motoruyla senkrotize �al���r.
        {
            _rigidbody.AddForce(Vector3.up * Time.deltaTime);
        }
    }
}


