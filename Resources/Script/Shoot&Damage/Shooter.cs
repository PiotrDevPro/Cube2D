using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] Direction pointingDirection;
    [SerializeField] float bulletsVelocity, timeBetweenShoot;
    [SerializeField] GameObject Bullets;
    public GameObject Menu;

    void Start()
    {
        StartCoroutine(Shoot());
    }

    IEnumerator Shoot()
    {
        GameObject go = new GameObject();

        while (true)
        {
            yield return new WaitForSeconds(timeBetweenShoot);
            


            switch (pointingDirection)
            {
                case Direction.UP:
                    go = Instantiate(Bullets, transform.position + new Vector3(0,1,0), Quaternion.identity);
                    go.GetComponent<Rigidbody2D>().velocity = new Vector2(0, bulletsVelocity);
                    break;
                case Direction.DOWN:
                    go = Instantiate(Bullets, transform.position + new Vector3(0, -1, 0), Quaternion.identity);
                    go.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -bulletsVelocity);
                    break;
                case Direction.RIGHT:
                    go = Instantiate(Bullets, transform.position + new Vector3(1, 0, 0), Quaternion.identity);
                    go.GetComponent<Rigidbody2D>().velocity = new Vector2(bulletsVelocity, 0);
                    break;
                case Direction.LEFT:
                    go = Instantiate(Bullets, transform.position + new Vector3(-1, 0, 0), Quaternion.identity);
                    go.GetComponent<Rigidbody2D>().velocity = new Vector2(-bulletsVelocity, 0);
                    break;
            }
        }

    }
 
}
