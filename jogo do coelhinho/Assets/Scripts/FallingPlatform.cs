using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatform : MonoBehaviour
{

    public float fallingTime;

    private TargetJoint2D tagert;
    private BoxCollider2D boxColl;

    // Start is called before the first frame update
    void Start()
    {
        tagert = GetComponent<TargetJoint2D>();
        boxColl = GetComponent<BoxCollider2D>();
    }

     void OnCollisionEnter2D(Collision2D collision)
    {
       if(collision.gameObject.tag == "Player") 
       {
          Invoke("Falling", fallingTime);
       }

    }

     void OnTriggerEnter2D(Collider2D collider)
    {
         if(collider.gameObject.layer == 9) 
       {
         Destroy(gameObject);
       }
    }

    void Falling()
    {
        tagert.enabled = false;
        boxColl.isTrigger = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
