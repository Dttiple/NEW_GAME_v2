using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EasyScore : MonoBehaviour
{

    public GameObject scoretext;
    public static float score = 0;

    private void Start()
    {
        setscore(0);
        
    }
    private void Update()
    {
        transform.Rotate(0, 0, 2f);
    }

    public void setscore(float scoretoadd)
    {
        score += scoretoadd;
        scoretext.GetComponent<Text>().text = score.ToString("SCORE: 0");
    }
     void Die()
        {
            Destroy(gameObject);
        }
  

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            setscore(100);
            Debug.Log("Colision enter");
            Die();
        }
    }

    /*
    private float currentScore;
    public float volumeScore;
    public Text scoreText;
    // Use this for initialization
    void Start()
    {
        currentScore = 0;

    }
    void Die()
    {
        Destroy(gameObject);
    }
    private void HandleScore()
    {
        scoreText.text = "SCORE: " + currentScore;
    }
   
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            currentScore ++;
            HandleScore();
            Debug.Log("Colision enter");
            Die();
        }
    }

    */
}

