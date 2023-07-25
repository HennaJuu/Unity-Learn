using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{

    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1;

    private float spawnInterval;



    void Start()
    {
          Invoke("SpawnRandomBall", startDelay);
    }


    void SpawnRandomBall()

    {
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        int randomBall = Random.Range(0, 3);

        Instantiate(ballPrefabs[randomBall], spawnPos, ballPrefabs[randomBall].transform.rotation);

        spawnInterval = Random.Range(3, 5);

        Invoke("SpawnRandomBall", spawnInterval);

    }
}