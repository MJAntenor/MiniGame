using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstaclePrefab;
    //public bool alive = true;
    public float respawnTime = 1.0f;

    private void Start()
    {
        spawnObstacle();
        //    StartCoroutine(Timer());
    }

    // Update is called once per frame
    void spawnObstacle()
    {
        //while (alive == true)
        //{
            Instantiate(obstaclePrefab);
            StartCoroutine(Buffer());
        //}
    }

     private IEnumerator Buffer()
    {
        yield return new WaitForSeconds(respawnTime);
        spawnObstacle();
    }
}
