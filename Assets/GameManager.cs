using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject enemy;

    float spawnIntervalSide = 3;
    float spawnIntervalUp = 4;
    float timeSinceLastSpawnSide;
    float timeSinceLastSpawnUp;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (timeSinceLastSpawnSide >= spawnIntervalSide)
        {
            int[] lanesx = new int[] {-20, 20 };
            float randomY = Random.Range(5, -1);
            int randomIndex = Random.Range(0, lanesx.Length);
            Instantiate(enemy, new Vector3(lanesx[randomIndex], randomY, 0), Quaternion.identity);
            timeSinceLastSpawnSide = 0;
        }

        if (timeSinceLastSpawnUp >= spawnIntervalUp)
        {
            float randomX = Random.Range(-10, 10);
            Instantiate(enemy, new Vector3(randomX, 11, 0), Quaternion.identity);
            timeSinceLastSpawnUp = 0;
        }
            timeSinceLastSpawnSide += Time.deltaTime;
            timeSinceLastSpawnUp += Time.deltaTime;
    }
}