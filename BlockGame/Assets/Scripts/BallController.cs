using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

    public float BallSpeed = 10;
    public Transform SpawnPosition;
    public GameObject Ball;
    public float ReviveCount;
    public GameObject[] Players;

    private void Awake()
    {
        GameObject obj = Instantiate(Ball, SpawnPosition.position, SpawnPosition.rotation);//게임오브젝트 변수 obj에 Ball프리팹을 SpawnPosition 위치랑 각도 저장

        obj.transform.SetParent(SpawnPosition);//변수 obj의 부모로 SpawnPosition을 설정
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
