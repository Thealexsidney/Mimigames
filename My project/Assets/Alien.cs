using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Alien : MonoBehaviour
{
    private float timer = 0f;
    private float time = 0f;
    public float reloadGame = 5f;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        time += Time.deltaTime;

        if (timer >= reloadGame ) SceneManager.LoadScene("Defend");

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        
        SceneManager.LoadScene("Golf");
        Destroy(gameObject);
    }
}
