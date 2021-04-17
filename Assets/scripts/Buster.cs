using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Buster : MonoBehaviour
{
    [SerializeField] // Указывается в инспекторе
    GameObject obj; // Объект, на котором Script1
    public float busterPowerUp = 600f;
    public float busterPowerDown = 400f;


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
