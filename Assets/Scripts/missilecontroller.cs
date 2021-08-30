using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missilecontroller : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y - speed*Time.deltaTime, this.transform.position.z);

        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "clean_up")
        {
            Destroy(gameObject);
        }
        if(other.tag == "Player")
        {
            Destroy(gameObject);
            PlayerController.instance.TurnOff();
        }
        if(other.tag == "shield")
        {
            Destroy(other.GetComponent<BoxCollider2D>().gameObject);
            Destroy(gameObject);
        }
    }
}
