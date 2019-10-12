using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    public const string Coins = "Coins";
    public const string Score = "Highscore";
    public const string Star = "Stars";
    public static int coins = 0;
    public static int star = 0;
    public static int score = 0;


    void Start()
    {
        //coins = PlayerPrefs.GetInt("Coins");
        star = PlayerPrefs.GetInt("Stars");
        score = PlayerPrefs.GetInt("Highscore");
       
    }


    public static void UpdateCoins()
    {
        PlayerPrefs.SetInt("Coins", coins);
        coins = PlayerPrefs.GetInt("Coins");
    }

    public static void UpdateStars()
    {
        PlayerPrefs.SetInt("Stars", star);
        star = PlayerPrefs.GetInt("Stars");
        PlayerPrefs.Save();
    }

    public static void UpdateScore()
    {
        PlayerPrefs.SetInt("Highscore", score);
        score = PlayerPrefs.GetInt("Highscore");
        PlayerPrefs.Save();
    }

}
