   using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class PlayerCollisionManager : MonoBehaviour
{
    public static int a = 4;
    private static bool trailOnOff = true; 
    PlayerMovement player;
    private TrailRenderer _player_trail;
    public Text tx_coin;
    public GameObject restarBtn;
    public GameObject blackScreen;
    public GameObject gameOver;
    RaycastHit2D hit;
    [SerializeField] float timeAfterKills;


    void Awake()
    {
        player = GetComponent<PlayerMovement>();
        _player_trail = GetComponent<TrailRenderer>();
    }

    private void Start()
    {
        _player_trail.enabled = true;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.tag == "Death")
          
        {
            switch (player.movingDir)
            {
                case Direction.UP:
                    //Debug.Log(player.movingDir);
                    restarBtn.SetActive(true);
                    blackScreen.SetActive(true);
                    Time.timeScale = 0;
                    _player_trail.enabled = false;
                    //Destroy(GameObject.Find("Player"));
                    break;
                case Direction.DOWN:
                    restarBtn.SetActive(true);
                    blackScreen.SetActive(true);
                    Time.timeScale = 0;
                    _player_trail.enabled = false;
                    break;
                case Direction.RIGHT:
                    restarBtn.SetActive(true);
                    blackScreen.SetActive(true);
                    Time.timeScale = 0;
                    _player_trail.enabled = false;
                    break;
                case Direction.LEFT:
                    restarBtn.SetActive(true);
                    blackScreen.SetActive(true);
                    Time.timeScale = 0;
                    _player_trail.enabled = false;
                    break;
                  
            }
     

            if (hit != null)
            {
 
                a -=1;
                if (a > 0 || a != 0)
                {
                    restarBtn.SetActive(true);
                    sound.PlaySound("die1");
                    deathPlaform.isMove = false;
                    return;
                }
                else
                {
                    sound.PlaySound("die1");
                    restarBtn.SetActive(false);
                    blackScreen.SetActive(false);
                    gameOver.SetActive(true);
                    Time.timeScale = 1;
                    Destroy(GameObject.Find("Player"));
                    deathPlaform.isMove = false;
                    return;
                }  
            }
        }


        if (col.collider.tag == "DeathAfterTime")
        {
            
            col.collider.GetComponent<SpikeAfterTime>().startCountDown();

        }
       
    }

 }


