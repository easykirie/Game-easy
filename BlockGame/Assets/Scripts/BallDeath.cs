using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDeath : MonoBehaviour {

    public float re;
    public GameObject Ball;

	// Use this for initialization
	void Start () {
        re = GetComponent<BallController>().ReviveCount;
	}	

	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Ball")
        {
            Destroy(Ball, 0.1f);
        }
    }
}
