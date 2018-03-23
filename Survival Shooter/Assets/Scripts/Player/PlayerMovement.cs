using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float speed = 6f;

    Vector3 movement;
    Animator anim;
    Rigidbody playerRigid;
    int floorMask;
    float camRayLength = 100f;

    private void Awake()
    {
        playerRigid = GetComponent<Rigidbody>();
    }

    // Use this for initialization
    void Start () {
		
	}

    private void FixedUpdate()
    {

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Move(h, v);
    }

    void Move(float h, float v)
    {
        movement.Set(h, 0, v);

        movement = movement.normalized * speed * Time.fixedDeltaTime;

        playerRigid.MovePosition(transform.position + movement);
        
    }
}
