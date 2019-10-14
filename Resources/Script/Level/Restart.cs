using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Restart : MonoBehaviour

{
    public GameObject playPanel;
    public GameObject blackScreen;
    public GameObject add_gold_panel;
    private TrailRenderer playTrail;
    private Text text;

    void Start()
    {
        text = GetComponent<Text>();
        playTrail =FindObjectOfType<PlayerCollisionManager>().GetComponent<TrailRenderer>();

    }

    public void RestartLevel()
    {

        Application.LoadLevel(Application.loadedLevel);
        SaveManager.coins = 0;
        Time.timeScale = 1f;
        deathPlaform.isMove = false;
        playTrail.enabled = true;

    }

    public void Play()
    {

        if (SaveManager.star > 100)
        {
            Time.timeScale = 1f;
            deathPlaform.isMove = false;
            playPanel.SetActive(false);
            blackScreen.SetActive(false);
            SaveManager.star -= 100;
            SaveManager.UpdateStars();
            playTrail.enabled = true;


        }
        else
        {

            Debug.Log("Need More Gold!!!");
            add_gold_panel.SetActive(true);
            sound.PlaySound("denied");
            return;
        }

    }

    public void addGold()
    {
        SaveManager.star += 100;
        SaveManager.UpdateStars();
        sound.PlaySound("Buy");
        add_gold_panel.SetActive(false);

    }

}



