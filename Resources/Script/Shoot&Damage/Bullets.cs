using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{

    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.tag == "Player")
        {

            Destroy(col.gameObject);
            Destroy(this.gameObject);
            //   }
            //  else

            //  Destroy(gameObject, 10f);


        }

        else if (col.collider.tag != "Shooter")

        {

            Destroy(this.gameObject);




        }




    }


}
