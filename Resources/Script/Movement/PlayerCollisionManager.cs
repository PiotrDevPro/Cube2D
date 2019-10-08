   using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionManager : MonoBehaviour
{
    PlayerMovement player;
    public GameObject restarBtn;
    RaycastHit2D hit;
    [SerializeField] LayerMask obstacleMask;
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
                    restarBtn.SetActive(true);
                    break;
                case Direction.DOWN:
                    Debug.Log(player.movingDir);
                    deathPlaform.isMove = false;
                    restarBtn.SetActive(true);
                    break;
                case Direction.RIGHT:
                    Debug.Log(player.movingDir);
                    deathPlaform.isMove = false;
                    restarBtn.SetActive(true);
                    break;
                case Direction.LEFT:
                    Debug.Log(player.movingDir);
                    deathPlaform.isMove = false;
                    restarBtn.SetActive(true);

                    break;
                    
            }

        

            if (hit != null)
            {
                Destroy(GameObject.Find("Player"));
                restarBtn.SetActive(true);
                sound.PlaySound("die1");

            }
        }


        if (col.collider.tag == "DeathAfterTime")
        {
            
            col.collider.GetComponent<SpikeAfterTime>().startCountDown();

        }

     
        
}

}


