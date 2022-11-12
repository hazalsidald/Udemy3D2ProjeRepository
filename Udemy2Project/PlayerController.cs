using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//name spaceler proje adý ve//dosya adý alýr.
namespace Udemy2Project.Controllers//name spacelerin görevi classlarýmýzý birbirinden ayýrmaktýr.
{
    public class PlayerController : MonoBehaviour
    {
      

        Rigidbody _rigidbody; //rigidbody fieldi
        Default _input;
        bool _isForceUp;

        private void Awake() //keþledim
        {
            _input = new
            _rigidbody = GetComponent<Rigidbody>(); //playerdaki rigidbady referansýný buraya alýr.yani eriþebilirim.
        }
        private void Update() //update ile ýnputlarý alýrýz.örneðin klavye basýcam bir veri var bu veriyi update ile alýrým.
        {                     // her bir fireymde bir çalýþýr, 1 sn 30 60 120 çalýþýr.
            
        }

        private void FixedUpdate()//fizik iþlemleri yaparým örnegin:rigidbady ,vollidorýn caprmasý , yürüme
                                     //standarttýr 0.2 sn þeklinde çalýþýr. ve fizik motoruyla senkrotize çalýþýr.
        {
            _rigidbody.AddForce(Vector3.up * Time.deltaTime);
        }
    }
}


