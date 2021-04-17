using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using UnityEngine.InputSystem;

public class ScenesMeneger : MonoBehaviour
{
    [SerializeField]
    GameObject MenuScreen;
    public void NextSchene(int _sceneNumber)
    {
        SceneManager.LoadScene(_sceneNumber);
    }
    public void ReloadThisScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void QuitGame()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
    
   
    
}
/*public class Menu_pause : MonoBehaviour
{
    [SerializeField]
    GameObject MenuScreen;
    bool GameIsPause = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPause)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }


    void Pause()
    {
        MenuScreen.SetActive(true);
        Time.timeScale = 0f;
        GameIsPause = true;
    
    
    }

    private void Resume()
    {
        MenuScreen.SetActive(false);
        Time.timeScale = 1f;
        GameIsPause = false;
    }

}*/