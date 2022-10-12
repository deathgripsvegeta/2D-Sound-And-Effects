using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 _spawnPos = new Vector3(10, -3, 0);
    private float _startDelay = 2;
    private float _repeatRate = 3.5f;
    void Start()
    {
        InvokeRepeating("SpawnObstacle", _startDelay, _repeatRate);
    }
    void SpawnObstacle()
    {
        Instantiate(obstaclePrefab, _spawnPos, obstaclePrefab.transform.rotation);
    }

   
}
