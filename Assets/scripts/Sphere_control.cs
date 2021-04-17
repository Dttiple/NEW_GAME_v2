using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere_control : MonoBehaviour
{
    public float Speed = 390f;
    public Rigidbody rb;

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

    void OnCollisionEnter(Collision collision)
    {


        if (collision.gameObject.tag == "Wave")
        {
            rb.transform.position = CheckPoint.GetActiveCheckPointPosition();

        }
        if (collision.gameObject.tag == "Saw")
        {
            rb.transform.position = CheckPoint.GetActiveCheckPointPosition();

        }
    }


}

