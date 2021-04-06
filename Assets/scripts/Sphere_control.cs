using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere_control : MonoBehaviour
{
    public float Speed;
    private Rigidbody rb;

    // Update is called once per frame

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        float xSpeed = Input.GetAxis("Horizontal");
        float ySpeed = Input.GetAxis("Vertical");
     
        rb.AddForce(new Vector3(xSpeed, 0, ySpeed) * Speed * Time.deltaTime);
    
    
    
    }

  
    }

