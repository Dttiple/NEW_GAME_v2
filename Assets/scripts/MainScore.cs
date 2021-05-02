using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MainScore : MonoBehaviour
{
    public GameObject mainScoretext;
    public  float Mainscore = 0;
    void Start()
    {
        Mainscore = EasyScore.score;
        SetScrore();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SetScrore()
    {
        mainScoretext.GetComponent<Text>().text = Mainscore.ToString("SCORE: 0");
    }
}
