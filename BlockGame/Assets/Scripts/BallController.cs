using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

    public float BallSpeed = 10;
    public Transform SpawnPosition;
    public GameObject Ball;
    public float ReviveCount;
    public GameObject[] Players;
    bool FirstCheck;
    Rigidbody rigid;

    private void Awake()
    {
        BallCreate();
    }
    // Use this for initialization
    void Start () {
        rigid = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        BallShoot();
	}

    void BallCreate()
    {
        GameObject obj = Instantiate(Ball, SpawnPosition.position, SpawnPosition.rotation);//게임오브젝트 변수 obj에 Ball프리팹을 SpawnPosition 위치랑 각도 저장

        obj.transform.SetParent(SpawnPosition);//변수 obj의 부모로 SpawnPosition을 설정

        FirstCheck = false;//FirstCheck를 false로 바꿔서 Space바를 누르면 발사가능하게 해줌.
    }

    void BallShoot()//FirstCheck가 false고 Space바를 누르면 발사. FirstCheck를 true로 바꿔줌.
    { 
        if(FirstCheck == false && Input.GetKeyDown(KeyCode.Space))
        {
            FirstCheck = true;
            rigid.AddForce(Vector3.up * BallSpeed, ForceMode.Impulse);           
        }
    }
    
}
