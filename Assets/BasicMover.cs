using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMover : MonoBehaviour {
    public bool spin = true;
    public float spinSpeed = 180f;
    public char spinAroundAxis;
   

    // Use this for initialization
    void Start ()
    {

	}
	
	// Update is called once per frame
	void Update ()
    {
        if (spin)
        {
            if (spinAroundAxis == 'X')
            {
                gameObject.transform.Rotate(Vector3.right * spinSpeed * Time.deltaTime);
            }
            else if (spinAroundAxis == 'Y')
            {
                gameObject.transform.Rotate(Vector3.up * spinSpeed * Time.deltaTime);
            }
            else if (spinAroundAxis == 'Z')
            {
                gameObject.transform.Rotate(Vector3.forward * spinSpeed * Time.deltaTime);
            }
        }
        else
        {

        }
        
	}
}
