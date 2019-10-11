using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Restart : MonoBehaviour

{
    public GameObject playPanel;
    public GameObject blackScreen;
    private Text text;
    void Start()
    {
        text = GetComponent<Text>();
    }

   public void RestartLevel()
    {

        Application.LoadLevel(Application.loadedLevel);
            SaveManager.coins = 0;
           deathPlaform.isMove = false;




    }

    public void Play()
    {
        Time.timeScale = 1f;
        deathPlaform.isMove = false;
        playPanel.SetActive(false);
        blackScreen.SetActive(false);
        transform.Translate(-1, -1, 0);
    }


}
