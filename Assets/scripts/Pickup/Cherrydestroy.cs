using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cherrydestroy : MonoBehaviour
{
    float xmin;
    float halfHeight;
    float halfWidth;
    // Start is called before the first frame update
    void Start()
    {
        halfHeight = Camera.main.orthographicSize;
        halfWidth = Camera.main.aspect * halfHeight;
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.transform.position.x<Camera.main.transform.position.x- halfWidth)
        {
            gameObject.active = false;
        }
        //if()
        //{

        //}
    }
    /* private void OnCollisionEnter2D(Collision2D collision)
     {

         gameObject.active = false;
     }*/
    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameObject.active = false;
    }

}
