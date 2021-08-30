using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float delayFire;
    public float currentDelayFire;

    public GameObject missile;



    // Start is called before the first frame update
    void Start()
    {
        currentDelayFire = randDelay(delayFire);
        
    }

    // Update is called once per frame
    void Update()
    {
        if(currentDelayFire > 0)
        {
            currentDelayFire -= Time.deltaTime;
            if (currentDelayFire <= 0)
            {
                Instantiate(missile,transform.position, transform.rotation); //  fire missile
            }

        } else
        {
            currentDelayFire = randDelay(delayFire);
        }
        
    }

    // private void OnTriggerEnter2D(Collider2D other) {
    //     if(other.tag == "bounce")
    //     {
    //         EnemiesController.instance.speed = -1 * EnemiesController.instance.speed;
    //         GameObject.other.SetActive(false);
    //     }
    // }

    private float randDelay(float maxDelay)
    {
        return Random.Range(1.0f, maxDelay);
    }
}
