using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ShowStars : MonoBehaviour
{
    private Text text;

    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = ((int)SaveManager.star).ToString();
    }
}
