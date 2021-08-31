using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesController : MonoBehaviour
{
    public static EnemiesController instance;

    public GameObject greenEnemy, yellowEnemy, redEnemy;
   
    public float speed, delayMove, dropSpeed;
    public float currentDelay, currentSpeed;

    public bool direction;
    private float left;



    private void Awake() {
        instance = this;
    }

    

    // Start is called before the first frame update
    void Start()
    {
        // Load enemies
        spawnEnemies();
      
    }

    // Update is called once per frame
    void Update()
    {
        currentDelay -= Time.deltaTime;
        if(currentDelay <= 0)
        {
            transform.position = new Vector3(transform.position.x + (currentSpeed*Time.deltaTime), transform.position.y, transform.position.z);
            currentDelay = delayMove;
            left = this.transform.childCount;
            if(left==0)
            {
                spawnEnemies();
            }else {
            delayMove = 0.3f + (left/36f/2f);
            }
        }
        if(currentSpeed > 0){
            direction = true;
        }else
        {
            direction = false;
        }

        
    }
    public void DropDown()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y-dropSpeed, transform.position.z);
        currentSpeed = -1 * currentSpeed;
        direction =  !direction;

  
    }


    private void spawnEnemies()
    {
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
}
