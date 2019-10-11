using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathPlaform : MonoBehaviour

{
    int b = 0;
    public float speedMoving;
    public static bool isDead = false;
    public static bool isMove = false;
   // public static bool onSpeed = false;

    void Start()
    { 
       if (isMove == true)
        {
            speedMoving = 0f;
        }
        else
        {
            speedMoving = 3.5f;
        }    

    }
    void Update()
    {
        if (isDead == true || isMove == false )
        
            return;

        {
            if (Pause.paused == true)
            {
                transform.Translate(0, speedMoving * Time.deltaTime, 0);
            }
        
            else
            {
                speedMoving += 0.0016f;
                transform.Translate(0, speedMoving * Time.deltaTime, 0);
            
        }

      //  if (onSpeed == true)
           // {
          //    Speed();
         // Debug.Log(speedMoving.ToString());
        //}
       // else if (onSpeed == false)
      //  {
         //     speedMoving = 4f;
            
        }
     
    }


    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            b += 1;
            Debug.Log(b);
            if (b != 4)
            
            {
                transform.Translate(0, -4, 0);

            }
            else
            {
                transform.Translate(0, 0, 0);
                sound.PlaySound("die1");

            }
        }
    }


}
