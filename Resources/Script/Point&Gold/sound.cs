using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour
{ 
    public static AudioClip coinUp,die,jump;

    public static AudioSource _audio;
 
    void Start()
    {
        _audio = GetComponent<AudioSource>();
        coinUp = Resources.Load<AudioClip>("audio/pickup");
        die = Resources.Load<AudioClip>("audio/die1");
        jump = Resources.Load<AudioClip>("audio/pickup2");
    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "pickup":
                _audio.PlayOneShot(coinUp,0.3f);
                break;
            case "die1":
                _audio.PlayOneShot(die);
                break;
            case "pickup2":
                _audio.PlayOneShot(jump);
                break;
        }
    }

    public void MusicOff()
    {
        _audio.mute = true;
    }
}
