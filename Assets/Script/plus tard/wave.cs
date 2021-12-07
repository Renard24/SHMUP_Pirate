using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wave : MonoBehaviour
{
    public GameObject Enemy = null;

    public int hazardCount = 3;
    public float spawnWait = 0.5f;
    public float startWait = 4;
    public float waveWait = 5f;
    public Transform[] spawnPoints;
    void Start()
    {
        StartCoroutine((string)SpawnWaves());
    }
    IEnumerable SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);
        while (true)
        {
            int spawnPointIndex = Random.Range(0, spawnPoints.Length); 

            for (int i = 0; i < hazardCount; i++)
            {
               
                Instantiate(Enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);

                yield return new WaitForSeconds(spawnWait);
            }
            yield return new WaitForSeconds(waveWait);

        }
    }
    
    void Update()
    {
        
    }
}
