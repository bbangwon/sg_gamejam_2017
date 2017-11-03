using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SGMonster : SGBCharacter
{
    public float moveSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //몬스터 이동 (플레이어 따라가기)
        transform.position = Vector2.Lerp(transform.position, SGGameManager.Instance.hero.transform.position, Time.deltaTime * moveSpeed);
	}
}
