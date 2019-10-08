using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedWall : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.tag == "Player")
        {
        //    deathPlaform.onSpeed = true;
            Destroy(this.gameObject);
            Debug.Log("GOGOGO");

        }
    }
}
