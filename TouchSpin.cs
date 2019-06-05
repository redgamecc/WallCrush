using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchSpin : MonoBehaviour {

    public float speed = 1f;

    // Use this for initialization
    void Start () {
		
	}
	
    void OnMouseDrag() {
        transform.Rotate(0, 0, -Input.GetAxis("Mouse X") * speed);
    }
    // Update is called once per frame
	void Update () {
        
	}
}
