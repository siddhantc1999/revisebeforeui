using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocks : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        transform.GetChild(0).transform.localPosition = new Vector3(0f,0.491f,0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
