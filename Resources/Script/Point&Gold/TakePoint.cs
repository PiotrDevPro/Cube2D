using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class TakePoint : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.tag == "Player")
        {

            SaveManager.coins += 1;
            deathPlaform.isMove = true;
            Destroy(gameObject);
           // sound.PlaySound("pickup");
          //  SaveManager.UpdateCoins();
        }

    }
}