using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldsController : MonoBehaviour
{
    public GameObject block;
    // Start is called before the first frame update

    private float locx, locy;
    private int[] blocks = new int[60] {0,0,1,1,1,1,1,1,0,0,
                            1,1,1,1,1,1,1,1,1,1,
                            1,1,1,1,1,1,1,1,1,1,
                            1,1,1,1,1,1,1,1,1,1,
                            1,1,1,1,1,1,1,1,1,1,
                            1,1,1,0,0,0,0,1,1,1};


    void Start()
    {
        for(int i=0; i<6;i++)
        {
            for(int j=0; j<10;j++)
            {
                if(blocks[i*10+j]== 1)
                {
                    locx = (float)j;
                    locx *= 0.1f;
                    locy = (float)i;
                    locy *= -0.1f;
                    Instantiate(block,new Vector3(this.transform.position.x+locx,this.transform.position.y+locy,0),transform.rotation,this.transform);
                }
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
