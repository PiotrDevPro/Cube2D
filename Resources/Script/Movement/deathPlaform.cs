using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class deathPlaform : MonoBehaviour

{
    public float speedMoving;
    public static bool isDead = false;
    public static bool isMove = false;


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
                //Debug.Log(speedMoving);
                speedMoving += 0.0011f;
                transform.Translate(0, speedMoving * Time.deltaTime, 0); 
            }
            
        }
     
    }


    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            int a = 4;
            a -= 1;

            if (a != 0 || a > 0)

            {
                transform.Translate(0, -10, 0);
                sound.PlaySound("die1");
                isMove = false;
                speedMoving -= 0.6f;


            }
            else
            {
                transform.Translate(0, 0, 0);
                sound.PlaySound("die1");
            }
        }
    }
}
