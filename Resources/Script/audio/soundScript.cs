using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class soundScript : MonoBehaviour
{
    private ToggleMusicBtn music;
    public Button toggleButton;
    public Sprite musicOnSprite;
    public Sprite musicOffSprite;

    void Start()
    {
        music = GameObject.FindObjectOfType<ToggleMusicBtn>();
        UpdateIcon();
    }

    public void PauseMusic()
    {
        music.ToggleSound(); // Update the playerPrefs
        UpdateIcon();
    }

    public void UpdateIcon()
    {
        if (PlayerPrefs.GetInt("Muted",0) == 0)
        {
            AudioListener.volume = 1;
            toggleButton.GetComponent<Image>().sprite = musicOnSprite;   
        }
        else
        {
            AudioListener.volume = 0;
            toggleButton.GetComponent<Image>().sprite = musicOffSprite;
        }
    }

}
