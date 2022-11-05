using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMoving : MonoBehaviour
{
   [SerializeField]
   private float _speed = 10f;

   

   private void Update()
   {
      var pozition = transform.position;
      var step = _speed * Time.deltaTime;
      
      if (Input.GetKey(KeyCode.W))
      {
         pozition.z += step;
         transform.position = pozition;
      }
      if (Input.GetKey(KeyCode.A))
      {
         pozition.x -= step;
         transform.position = pozition;
      }
      if (Input.GetKey(KeyCode.D))
      {
         pozition.x += step;
         transform.position = pozition;
      }
      if (Input.GetKey(KeyCode.S))
      {
         pozition.z -= step;
         transform.position = pozition;
      }
   }
}
