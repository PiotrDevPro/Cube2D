using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{

    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.tag == "Player")
        {
            Destroy(this.gameObject);
            
        }

        else if (col.collider.tag != "Shooter")

        {

            Destroy(this.gameObject);

        }

    }

}
