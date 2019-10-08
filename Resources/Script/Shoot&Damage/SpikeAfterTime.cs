using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeAfterTime : MonoBehaviour
{
    
    List<Direction> dirOfTouch = new List<Direction>();
    [SerializeField] float countDown;
    [SerializeField] LayerMask playerMask;
    public GameObject Menu;



    public void startCountDown()
    {
        if (Physics2D.Raycast(transform.position, transform.TransformDirection(Vector2.up), 0.6f, playerMask)) dirOfTouch.Add(Direction.UP);
        if (Physics2D.Raycast(transform.position, transform.TransformDirection(Vector2.down), 0.6f, playerMask)) dirOfTouch.Add(Direction.DOWN);
        if (Physics2D.Raycast(transform.position, transform.TransformDirection(Vector2.right), 0.6f, playerMask)) dirOfTouch.Add(Direction.LEFT);
        if (Physics2D.Raycast(transform.position, transform.TransformDirection(Vector2.left), 0.6f, playerMask)) dirOfTouch.Add(Direction.RIGHT);


        StartCoroutine(killPlayer(countDown));

        

    }

    IEnumerator killPlayer(float unitTime)
    {
        yield return new WaitForSeconds(unitTime);

        foreach (Direction dir in dirOfTouch)
        {

            if (Physics2D.Raycast(transform.position, transform.TransformDirection(Vector2.up), 0.6f, playerMask) && dir == Direction.UP) Destroy(GameObject.Find("Player")) ;
            else if (Physics2D.Raycast(transform.position, transform.TransformDirection(Vector2.down), 0.6f, playerMask) && dir == Direction.DOWN) Destroy(GameObject.Find("Player"));
            else if (Physics2D.Raycast(transform.position, transform.TransformDirection(Vector2.right), 0.6f, playerMask) && dir == Direction.LEFT) Destroy(GameObject.Find("Player"));
            else if (Physics2D.Raycast(transform.position, transform.TransformDirection(Vector2.left), 0.6f, playerMask) && dir == Direction.RIGHT) Destroy(GameObject.Find("Player"));
        }

        Menu.SetActive(true);

    }

    
}
