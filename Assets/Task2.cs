using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task2 : MonoBehaviour {

    public bool spin = true;
    public float spinSpeed = 210f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        gameObject.transform.Rotate(Vector3.left * spinSpeed * Time.deltaTime);
	}
}
