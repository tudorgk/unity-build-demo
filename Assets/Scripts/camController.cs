using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class camController : MonoBehaviour {

	Vector3 targetPosition;
	GameObject[] balls;

	void Awake () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		balls = GameObject.FindGameObjectsWithTag ("Player");
		targetPosition = Vector3.zero;
		foreach( GameObject g in balls ){
			targetPosition += g.transform.position;
		}
		targetPosition /= balls.Length;
		transform.position = Vector3.Lerp (transform.position, targetPosition+Vector3.up*10, 0.05f);
	}
}
