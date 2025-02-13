using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BarGame : MonoBehaviour
{

    public RectTransform cursor; 

    public RectTransform bar; 

    public RectTransform targetZone; 



    public float speed = 300f; 

    private bool movingRight = true;



    void Update()

    {

        MoveCursor();

        CheckForWin();

    }



    void MoveCursor()

    {

        

        float barLeft = bar.position.x - (bar.rect.width / 2);

        float barRight = bar.position.x + (bar.rect.width / 2);



        

        if (movingRight)

            cursor.position += Vector3.right * speed * Time.deltaTime;

        else

            cursor.position -= Vector3.right * speed * Time.deltaTime;



        

        if (cursor.position.x >= barRight)

            movingRight = false;

        if (cursor.position.x <= barLeft)

            movingRight = true;

    }



    void CheckForWin()

    {

        

        if (Input.GetKeyDown(KeyCode.Space))

        {

            float cursorLeft = cursor.position.x - (cursor.rect.width / 2);

            float cursorRight = cursor.position.x + (cursor.rect.width / 2);



            float targetLeft = targetZone.position.x - (targetZone.rect.width / 2);

            float targetRight = targetZone.position.x + (targetZone.rect.width / 2);



            

            if (cursorRight >= targetLeft && cursorLeft <= targetRight)

            {

                SceneManager.LoadScene("Defend");

            }


        }

    }

}
