using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletspawner : MonoBehaviour
{
 


    [Header("Bullet Attributes")]
    public GameObject bullet;
    public float bulletLife = 1f;
    public float speed = 1f;
    public float Rotate = 0.1f;
    bool bulletSpawned = false;

   

    private GameObject spawnedBullet;
   



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
        
        if (transform.eulerAngles.z >= 180)
        {
            transform.eulerAngles = new Vector3(0f, 0f, transform.eulerAngles.z - Rotate * Time.deltaTime);
        }
        if (transform.eulerAngles.z >= 0 && transform.eulerAngles.z < 180)
        {
            transform.eulerAngles = new Vector3(0f, 0f, transform.eulerAngles.z + Rotate * Time.deltaTime);
        }

        else
        {
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }




        if (Input.GetKey(KeyCode.Space)) 
        {
            if (!bulletSpawned) 
            {
                Fire();
                bulletSpawned=true;
            }
        }
    }

    private void Fire()
    {
        if (bullet)
        {
            spawnedBullet = Instantiate(bullet, transform.position, Quaternion.identity);
            spawnedBullet.GetComponent<SimpleBullet>().speed = speed;
            spawnedBullet.GetComponent<SimpleBullet>().bulletLife = bulletLife;
            spawnedBullet.transform.rotation = transform.rotation;
        }
    }

}
