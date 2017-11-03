using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SGHero : MonoBehaviour {

    public SGJoystick joystick;
    Vector3 _moveVector;
    public float moveSpeed;

    // Use this for initialization
    void Start () {
        _moveVector = Vector3.zero;

    }
	
	// Update is called once per frame
	void Update () {
        HandleMoveInput();
    }

    void FixedUpdate()
    {
        Move(); 
    }

    public void HandleMoveInput()
    {
        _moveVector = new Vector3(joystick.GetHorizontalValue(), joystick.GetVerticalValue(), 0f).normalized;
    }

    public void Move()
    {
        transform.Translate(_moveVector * moveSpeed * Time.deltaTime);
    }
}
