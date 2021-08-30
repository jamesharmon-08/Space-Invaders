using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncingController : MonoBehaviour
{
    public GameObject twin;
    public bool direction;  // true = positive, false = negative

    // Start is called before the first frame update
    void Start()
    {
        if(twin.activeInHierarchy)
        {
            gameObject.SetActive(false);
        } else
        {
            gameObject.SetActive(true);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
 
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Enemy")
        {
            if(direction && EnemiesController.instance.speed > 0)
            {
                gameObject.SetActive(false);
                twin.SetActive(true);
                EnemiesController.instance.speed = EnemiesController.instance.speed * -1;;
            }
            if(!direction && EnemiesController.instance.speed < 0)
            {
                gameObject.SetActive(false);
                twin.SetActive(true);
                EnemiesController.instance.speed = EnemiesController.instance.speed * -1;
            }
           
        }
    }

    private void flip()
    {
        if(twin.activeInHierarchy)
        {
            gameObject.SetActive(false);
        } else
        {
            gameObject.SetActive(true);
        }
    }
}
