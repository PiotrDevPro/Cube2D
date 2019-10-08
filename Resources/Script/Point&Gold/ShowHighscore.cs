using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ShowHighscore : MonoBehaviour
{
    private Text text;

    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = ((int)SaveManager.score).ToString();
    }
}
