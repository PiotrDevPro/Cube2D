using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeCoin : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.tag == "Player")
        {
            SaveManager.star += 1;
            SaveManager.UpdateStars();
            sound.PlaySound("pickup");
            Destroy(gameObject);

        }
    }

}
