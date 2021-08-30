using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{

    public float speed, delayMove;
    private float currentDelay;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
     void Update()
    {
        currentDelay -= Time.deltaTime;
        if(currentDelay <= 0)
        {
            transform.position = new Vector3(transform.position.x + (speed*Time.deltaTime), transform.position.y, transform.position.z);
            currentDelay = delayMove;
        }
        
    }
}
