using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tytor_panel : MonoBehaviour
{
    public GameObject tytor_panel;
    private bool locked = false;


    public void ActiveWindow()
    {
        tytor_panel.SetActive(false);
        locked = true;
    }
    private void Update()
    {
        if (locked == false)
        {
            Time.timeScale = 1f;
        
        }
       if(locked == true)
        {
            Time.timeScale = 0f;
        }
    }
}
