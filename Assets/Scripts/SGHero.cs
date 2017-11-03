using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CnControls;

public class SGHero : MonoBehaviour {

    public float moveSpeed;

    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
    }

    private void FixedUpdate()
    {
        float h = CnInputManager.GetAxis("Horizontal");
        float v = CnInputManager.GetAxis("Vertical");

        Debug.Log(h);

        transform.Translate(new Vector3(h, v, 0f) * moveSpeed * Time.deltaTime);
    }
}
