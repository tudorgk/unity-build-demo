using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class timeScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		GetComponent<Text>().text = "Time: " + (int)Time.time;
	}
}
