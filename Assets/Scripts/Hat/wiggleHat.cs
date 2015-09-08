using UnityEngine;
using System.Collections;


public class wiggleHat : MonoBehaviour {
	
	public float speed;
	public bool animate;

	private Quaternion originalRotationValue; // declare this as a Quaternion
	private float rotationResetSpeed;

	// Use this for initialization
	void Start () {
		originalRotationValue = transform.rotation; // save the initial rotation
	}

	
	// Update is called once per frame
	void Update () {
		if (animate){
			float _sinVal = Mathf.Sin(speed*Time.time);  
			float _cosVal = Mathf.Cos(speed*Time.time); 


//			if(_sinVal > Mathf.2 || _sinVal < -0.2)
//				_sinVal = (_sinVal < 0) ? -0.2f : 0.2f;
//		
//			if(_cosVal > 0.2 || _cosVal < -0.2)
//				_cosVal = (_cosVal < 0) ? -0.2f : 0.2f;


			Debug.Log("sin: " + _sinVal + "\n cos: " + _cosVal);

			transform.Rotate(_sinVal * speed,_sinVal * speed,0, Space.World );
		}else{
			transform.rotation = Quaternion.Slerp(transform.rotation, originalRotationValue, Time.time * rotationResetSpeed); 
		}


	}


}
