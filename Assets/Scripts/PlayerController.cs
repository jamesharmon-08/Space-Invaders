using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D theRB;
    public float moveSpeed;

    public GameObject laser;

    public bool invincible;
    

    public static PlayerController instance;

    private void Awake() {
        instance = this;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        theRB.velocity = new Vector2(Input.GetAxisRaw("Horizontal"),0)*moveSpeed;

        if(Input.GetMouseButtonDown(0))
        {
            Instantiate(laser, transform.position, transform.rotation);
        }
        
    }
    public void TurnOff()
    {
        if(!invincible)
        {
            gameObject.SetActive(false);
        }
    }
}
