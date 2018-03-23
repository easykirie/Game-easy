using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockCreate : MonoBehaviour {

    public int MaximumCount;
    public int MinimumCount;    
    public Transform[] SpawnPosition;
    public GameObject Ball;
    int[] BlockPosition;
    int CreateIndex;

    

    // Use this for initialization
    void Start () {
        int count = Random.Range(MaximumCount, MinimumCount);

        while(CreateIndex <= count)
        {
            Instantiate(Prefabs, transform.position, transform.rotation);
        }
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
