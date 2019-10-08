using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpandingBalls : MonoBehaviour
{

    [SerializeField] float timeUnExpended,timeExpended;

    void Start()
    {
        StartCoroutine(ExpansionCycle());
    }
    IEnumerator ExpansionCycle()

    {
        Object[] go = new Object[8];

        while (true)
        {
            yield return new WaitForSeconds(timeUnExpended);

            
            go[0] = Instantiate(Resources.Load("Prefab/Enemy&Damage/ExpandingBallsSpike"), transform.position + new Vector3(1,0,0),Quaternion.identity);
            go[1] = Instantiate(Resources.Load("Prefab/Enemy&Damage/ExpandingBallsSpike"), transform.position + new Vector3(1, 1, 0), Quaternion.identity);
            go[2] = Instantiate(Resources.Load("Prefab/Enemy&Damage/ExpandingBallsSpike"), transform.position + new Vector3(1, -1, 0), Quaternion.identity);
            go[3] = Instantiate(Resources.Load("Prefab/Enemy&Damage/ExpandingBallsSpike"), transform.position + new Vector3(-1, 0, 0), Quaternion.identity);
            go[4] = Instantiate(Resources.Load("Prefab/Enemy&Damage/ExpandingBallsSpike"), transform.position + new Vector3(-1, 1, 0), Quaternion.identity);
            go[5] = Instantiate(Resources.Load("Prefab/Enemy&Damage/ExpandingBallsSpike"), transform.position + new Vector3(-1,-1, 0), Quaternion.identity);
            go[6] = Instantiate(Resources.Load("Prefab/Enemy&Damage/ExpandingBallsSpike"), transform.position + new Vector3(0, 1, 0), Quaternion.identity);
            go[7] = Instantiate(Resources.Load("Prefab/Enemy&Damage/ExpandingBallsSpike"), transform.position + new Vector3(0, -1, 0), Quaternion.identity);

            yield return new WaitForSeconds(timeExpended);

            for (int i = 0; i < 8; i++)
            {
                Destroy(go[i]);
            }
        }
    }

}
