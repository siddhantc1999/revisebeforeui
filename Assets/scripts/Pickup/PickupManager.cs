using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupManager : MonoBehaviour
{
    [SerializeField] GameObject cherry;
    GameObject cherrygameobject;
    float y;
    Vector3 xmin;
    Vector3 xmax;
    float randnumber;
    /*float xmaxworldpos;*/
   /* randomizeblock myrandomizeblock;*/
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<PlayerManager>().Targetreachedevent += throwcherry;
        cherrygameobject = Instantiate(cherry,Vector3.zero,Quaternion.identity);
        cherrygameobject.SetActive(false);
      /*  xmaxworldpos = Camera.main.ViewportToWorldPoint(new Vector3(1,0)).x;*/
      /*  myrandomizeblock = FindObjectOfType<randomizeblock>();*/

    }

    // Update is called once per frame
    void Update()
    {

        
    }

    [System.Obsolete]
    public void throwcherry()
    {


        xmin = BlockManager.Instance.xmid;
        xmax = BlockManager.Instance.xmax;
       
        randnumber = Random.Range(1,4);
        if ((randnumber==1 || randnumber==2 )&& cherrygameobject.active==false)
        {
           
            cherrygameobject.SetActive(true);
            if(randnumber==1)
            {
                y = -2.5f;
            }
            else
            if(randnumber == 2)
            {
                y = -1.87f;
            }
            cherrygameobject.transform.position = new Vector3(Random.Range(xmin.x+2f,xmax.x-2f), y, 0f);
        }
    }

}
