using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public static bool GameIsPaused = false;
    public GameObject MenuUi;
    // Start is called before the first frame update
  
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {

            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        Time.timeScale = 1f;
        MenuUi.SetActive(false);
        GameIsPaused = false;
    }

    public void Pause()
    {
        Time.timeScale = 0f;
        MenuUi.SetActive(true);
        GameIsPaused = true;
    }
    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
    public void QuitGame() 
    {
        Debug.Log("Quit game");
        Application.Quit();
    }
}
