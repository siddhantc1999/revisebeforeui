using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundrandomize : MonoBehaviour
{
    public List<Material> environments;
    Renderer renderer;
    int environmentcount;
    // Start is called before the first frame update
    void Start()
    {
        environmentcount = Random.Range(0, environments.Count + 1);
        renderer = GetComponent<MeshRenderer>();
        

        //renderer.materials[0] = environments[environmentcount];
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
