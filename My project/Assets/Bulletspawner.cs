using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class Bulletspawner : MonoBehaviour
{
 


    [Header("Bullet Attributes")]
    public GameObject bullet;
    public float bulletLife = 1f;
    public float speed = 1f;
    public float Rotate = 0.1f;
    bool bulletSpawned = false;
    private float targetAngle = 180f;
    private float timer = 0;
    public float reload = 2;

    private GameObject spawnedBullet;
   



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer + 1 * Time.deltaTime;
       
        if (timer >= reload) bulletSpawned=false;



        if (targetAngle == 180f)
        {
            transform.eulerAngles = new Vector3(0f, 0f, transform.eulerAngles.z + Rotate * Time.deltaTime);
        }

        if (targetAngle == 0f)
        {
            transform.eulerAngles = new Vector3(0f, 0f, transform.eulerAngles.z - Rotate * Time.deltaTime);
        }

        if (transform.eulerAngles.z >= 180f)
        {
            targetAngle = 0f;
        }
        if (transform.eulerAngles.z <= 1f)
        {
            targetAngle = 180f;
        }



        if (Input.GetKey(KeyCode.Space)) 
        {
            if (!bulletSpawned) 
            {
                Fire();
                bulletSpawned=true;
                timer=0;
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
