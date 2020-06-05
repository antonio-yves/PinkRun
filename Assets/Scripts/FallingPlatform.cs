using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatform : MonoBehaviour
{
    public float fallingTime;
    private TargetJoint2D joint;
    private BoxCollider2D boxCollider;
    // Start is called before the first frame update
    void Start()
    {
        joint = GetComponent<TargetJoint2D>();
        boxCollider = GetComponent<BoxCollider2D>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Invoke("Falling", fallingTime);
        }
    }

    void Falling(){
        joint.enabled = false;
        boxCollider.isTrigger = true;
    }

    void OnTriggerEnter2D(Collider2D collider){
        if (collider.gameObject.layer == 9){
            Destroy(gameObject);
        }
    }
}
