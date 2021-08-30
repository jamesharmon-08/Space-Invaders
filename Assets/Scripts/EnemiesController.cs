using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesController : MonoBehaviour
{
    public static EnemiesController instance;

    public GameObject greenEnemy, yellowEnemy, redEnemy;
   
    public float speed, delayMove;
    private float currentDelay, currentSpeed;


    private void Awake() {
        instance = this;
    }

    

    // Start is called before the first frame update
    void Start()
    {
        // Load enemies

        for(int j=0; j<2; j++)
        {
            for(int i=0; i<9; i++)
            {
                Instantiate(greenEnemy, new Vector3(transform.position.x+(i-4),transform.position.y+(2-j),transform.position.z), transform.rotation,this.transform);
            }
        }
        for(int i=0; i<9; i++)
        {
            Instantiate(yellowEnemy, new Vector3(transform.position.x+(i-4),transform.position.y+(3),transform.position.z), transform.rotation,this.transform);

        }
        for(int i=0; i<9; i++)
        {
            Instantiate(redEnemy, new Vector3(transform.position.x+(i-4),transform.position.y+(4),transform.position.z), transform.rotation,this.transform);

        }
        currentDelay = delayMove;
        currentSpeed = speed;
        
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
