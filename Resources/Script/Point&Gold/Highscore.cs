using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Highscore : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.tag == "Player")
        {

            if ((SaveManager.coins) > (SaveManager.score))
            {
                SaveManager.score += 1;
                SaveManager.score = SaveManager.coins;
                SaveManager.UpdateScore();
            }


        }

        

    }

}
