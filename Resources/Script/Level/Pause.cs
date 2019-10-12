using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject PauseUI;
    public static bool paused = false;



    void Start()
    {
        PauseUI.SetActive(false);

    }

    void Update()
    {
  
        if (Input.GetKeyDown(KeyCode.Pause)) 
        {
            paused = !paused;


            if (paused)
            {
                Resume();
            }

            else
            {
                PauseMe();
            }

        }

    }

        public void Resume()
        {
        PauseUI.SetActive(false);
        Time.timeScale = 1f;
        paused = false;
          
        }

    public void Quit()
    {
        Application.Quit();
        
    }

    public void PauseMe()
    {
        PauseUI.SetActive(true);
        Time.timeScale = 0f;
        paused = true;

    }

    public void RestartLevel()
    {
       
        paused = false;
        Application.LoadLevel(Application.loadedLevel);
        SaveManager.coins = 0;
        Time.timeScale = 1f;
        deathPlaform.isMove = false;

    }


}
