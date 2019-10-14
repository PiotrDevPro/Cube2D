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
                    Debug.Log(player.movingDir);
                    deathPlaform.isMove = false;
                    Time.timeScale = 0;
                    restarBtn.SetActive(true);
                    blackScreen.SetActive(true);
                    _player_trail.enabled = false;
                    //    Destroy(GameObject.Find("Player"));
                    break;
                case Direction.DOWN:
                    Debug.Log(player.movingDir);
                    deathPlaform.isMove = false;
                    Time.timeScale = 0;
                    restarBtn.SetActive(true);
                    blackScreen.SetActive(true);
                    _player_trail.enabled = false;
                    break;
                case Direction.RIGHT:
                    Debug.Log(player.movingDir);
                    deathPlaform.isMove = false;
                    Time.timeScale = 0;
                    restarBtn.SetActive(true);
                    blackScreen.SetActive(true);
                    _player_trail.enabled = false;
                    break;
                case Direction.LEFT:
                    Debug.Log(player.movingDir);
                    deathPlaform.isMove = false;
                    Time.timeScale = 0;
                    restarBtn.SetActive(true);
                    blackScreen.SetActive(true);
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
                }
                else
                {
                    sound.PlaySound("die1");
                    restarBtn.SetActive(false);
                    blackScreen.SetActive(false);
                    gameOver.SetActive(true);
                    Time.timeScale = 1;
                    Destroy(GameObject.Find("Player"));
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


