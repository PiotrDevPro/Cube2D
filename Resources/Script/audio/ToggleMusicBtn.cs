using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ToggleMusicBtn : MonoBehaviour
{
  //  public Toggle tgl_btn;
  //  public Text tgl_txt;
  //  private AudioSource _audio_toggle;
    static ToggleMusicBtn instance = null;

    private void Awake()
    {
    if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            GameObject.DontDestroyOnLoad(gameObject);
        }
   
    }

    public void ToggleSound()
    {
        if (PlayerPrefs.GetInt("Muted",0) == 0)
        {
            PlayerPrefs.SetInt("Muted", 1);

        }
        else
        {
            PlayerPrefs.SetInt("Muted", 0);
        }
    }      

}
