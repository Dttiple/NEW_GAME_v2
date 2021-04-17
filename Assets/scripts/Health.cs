using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour

{

    [SerializeField] // Указывается в инспекторе
    GameObject obj; // Объект, на котором Script1

    public GameObject LoseScreen;
    public int health;
    public int numbers_life;

    public Image[] lives;
    public GameObject spawnpoint;
    public Sprite fullLive;
    public Sprite emptyLive;

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (health > numbers_life)
        {
            health = numbers_life;
        }

        for (int i = 0; i < lives.Length; i++)
        {
            if (i < health)
            {
                lives[i].sprite = fullLive;
            }
            else
            {
                lives[i].sprite = emptyLive;
            }

            if (i < numbers_life)
            {
                lives[i].enabled = true;
            }
            else
            {
                lives[i].enabled = false;
            }
        }

        if (health <= 0)
        {
            Die();
        }
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.transform.tag == "Wave")
        {
            health--;
            
             
            
        }
        if (col.transform.tag == "Saw")
        {
            health--;



        }
    }

    

    void Die()
    {
        LoseScreen.gameObject.SetActive(true);
        obj.GetComponent<Sphere_control>().Speed = 0;
    }
}

