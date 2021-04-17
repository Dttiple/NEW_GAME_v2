using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buster_Controll : MonoBehaviour
{
    [SerializeField] // Указывается в инспекторе
    GameObject obj; // Объект, на котором Script1
    public float busterPowerUp = 800f;
    public float busterPowerDown = 390f;


    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            obj.GetComponent<Sphere_control>().Speed = busterPowerUp;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            obj.GetComponent<Sphere_control>().Speed = busterPowerDown;
        }
    }
}
