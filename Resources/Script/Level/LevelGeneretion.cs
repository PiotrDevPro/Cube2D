using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGeneretion : MonoBehaviour
{

    [SerializeField] int mapIndex = 2;

    void Start()
    {

        Texture2D texture = Resources.Load<Texture2D>("Map/" + mapIndex);

        Color color;

        for (int y = 0; y < texture.height; y++)
        {
            for (int x = 0; x < texture.width; x++)
            {
                color = texture.GetPixel(x, y);

              //  Debug.Log(color.ToString());
                switch (color.ToString())
                {
                    case "RGBA(0,000, 0,000, 0,000, 1,000)":
                        Instantiate(Resources.Load("Prefab/Texture & Sprite/wall"), new Vector3(x + .5f, y + .5f, 0), Quaternion.identity);
                        break;
                    case "RGBA(0,000, 0,000, 1,000, 1,000)":
                        Instantiate(Resources.Load("Prefab/Enemy&Damage/DamageAttack"), new Vector3(x + .5f, y + .5f, 0), Quaternion.identity);
                        break;
                    case "RGBA(0,000, 1,000, 1,000, 1,000)":
                        Instantiate(Resources.Load("Prefab/Enemy&Damage/DeathWall"), new Vector3(x + .5f, y + .5f, 0), Quaternion.identity);
                        break;
                    case "RGBA(1,000, 1,000, 1,000, 1,000)":
                        Instantiate(Resources.Load("Prefab/Enemy&Damage/ExpandingBalls"), new Vector3(x + .5f, y + .5f, 0), Quaternion.identity);
                        break;
                    case "RGBA(1,000, 0,000, 1,000, 1,000)":
                        Instantiate(Resources.Load("Prefab/Enemy&Damage/Shooter"), new Vector3(x + .5f, y + .5f, 0), Quaternion.identity);
                        break;
                    case "RGBA(0,000, 1,000, 0,000, 1,000)":
                        Instantiate(Resources.Load("Prefab/Enemy&Damage/Bullet"), new Vector3(x + .5f, y + .5f, 0), Quaternion.identity);
                        break;
            

                }
            }

        }

    }

}


  




