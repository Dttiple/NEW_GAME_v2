using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BladeController : MonoBehaviour
{
    
    public float speedRotation = 1f;


   

    void Update()
    {
        transform.Rotate(speedRotation, 0, 0);
       
    }
   

}



    





