using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Restart : MonoBehaviour

{
    private Text text;
    void Start()
    {
        text = GetComponent<Text>();
      //  deathPlaform.isMove = false;
    }

    // Update is called once per frame
    void Update()
    {
      
    }

   public void RestartLevel()
    {

        Application.LoadLevel(Application.loadedLevel);
      //  if ((SaveManager.score) < SaveManager.coins)
         //   text.text = ((int)SaveManager.score).ToString();
            SaveManager.coins = 0;
           deathPlaform.isMove = false;




    }

   


}
