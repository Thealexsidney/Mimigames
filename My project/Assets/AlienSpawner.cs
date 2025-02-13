using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienSpawner : MonoBehaviour
{
    public GameObject spawnObject;
    public Transform pointA;
    public Transform pointB;


    void Start()
    {
        Spawn();
    }




    public void Spawn()
    {
        Vector3 spawnPosition = Vector3.Lerp(pointA.position, pointB.position, Random.RandomRange(0f,1f));

        Vector3 spawnZ = new Vector3(spawnPosition.x, spawnPosition.y, 0);

        Instantiate(spawnObject, spawnZ, Quaternion.identity);
    }


}
