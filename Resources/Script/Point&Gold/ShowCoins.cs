using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ShowCoins : MonoBehaviour
{
    private Text text;

    void Start()
    {
        text = GetComponent<Text>();
    }

    void Update()
    {
        //string[] temp = text.text.Split(':');
        text.text = ((int)SaveManager.coins).ToString();

      //  temp[0] + ":"
    }
}
