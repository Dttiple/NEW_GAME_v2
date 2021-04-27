using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
   [SerializeField]
    // Start is called before the first frame update
    public GameObject EndScreen;
  
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            EndScreen.gameObject.SetActive(true);
            
        }
    }
}
