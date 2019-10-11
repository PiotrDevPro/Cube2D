   using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionManager : MonoBehaviour
{
    int a = 0;
    PlayerMovement player;
    public GameObject restarBtn;
    public GameObject blackScreen;
    public GameObject gameOver;
    RaycastHit2D hit;
    [SerializeField] float timeAfterKills;


    void Start()
    {
        player = GetComponent<PlayerMovement>();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.tag == "Death")
          
        {
            switch (player.movingDir)
            {
                case Direction.UP:
                    Debug.Log(player.movingDir);
                    deathPlaform.isMove = false;
                    Time.timeScale = 0;
                    restarBtn.SetActive(true);
                    blackScreen.SetActive(true);
                    gameOver.SetActive(false);
                    break;
                case Direction.DOWN:
                    Debug.Log(player.movingDir);
                    deathPlaform.isMove = false;
                    Time.timeScale = 0;
                    restarBtn.SetActive(true);
                    blackScreen.SetActive(true);
                    gameOver.SetActive(false);
                    break;
                case Direction.RIGHT:
                    Debug.Log(player.movingDir);
                    deathPlaform.isMove = false;
                    Time.timeScale = 0;
                    restarBtn.SetActive(true);
                    blackScreen.SetActive(true);
                    gameOver.SetActive(false);
                    break;
                case Direction.LEFT:
                    Debug.Log(player.movingDir);
                    deathPlaform.isMove = false;
                    Time.timeScale = 0;
                    restarBtn.SetActive(true);
                    blackScreen.SetActive(true);
                    gameOver.SetActive(false);
                    break;
                    
            }

        

            if (hit != null)
            {
                a+=1;
                Debug.Log(a);
                if (a != 4)

                {
                    restarBtn.SetActive(true);
                    Time.timeScale = 0;
                    transform.Translate(0,0,0);
                }
                else
                {

                    Destroy(GameObject.Find("Player"));
                    sound.PlaySound("die1");
                    restarBtn.SetActive(false);
                    gameOver.SetActive(true);
                }

            }
        }


        if (col.collider.tag == "DeathAfterTime")
        {
            
            col.collider.GetComponent<SpikeAfterTime>().startCountDown();

        }
       
    
    }

}


