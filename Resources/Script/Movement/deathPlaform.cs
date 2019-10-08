using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathPlaform : MonoBehaviour

{
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
                Debug.Log(speedMoving.ToString());
            }
        
            else
            {
                speedMoving += 0.0016f;
                transform.Translate(0, speedMoving * Time.deltaTime, 0);
                Debug.Log(speedMoving.ToString());
               
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
            transform.Translate(0, 0, 0);
            Death();
            Debug.Log("dead");
        }
    }
    private void Death()
    {
      //  isDead = true;
        sound.PlaySound("die1");
       // isMove = true;
    }

   // private void Speed()
  //  {
       // speedMoving +=0.02f;
  //  }

  

}
