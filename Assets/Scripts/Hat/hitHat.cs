using UnityEngine;
using System.Collections;

public class hitHat : MonoBehaviour {


	public static GameObject attachedPlayerObject;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (attachedPlayerObject != null){

			Vector3 newPos = attachedPlayerObject.transform.position;
			newPos.y += 1;

			transform.position = newPos;
		}
		                                
	}

	public static bool hasHat (GameObject ball){
		if(attachedPlayerObject == ball){
			return true;
		}else{
			return false;
		}
	}

	public string getTag(){
		return gameObject.tag;
	}

	void OnCollisionEnter(Collision collision ) {
		Debug.Log("On collision enter");


		//debug trace
		foreach (var contact in collision.contacts) {
			Debug.DrawRay(contact.point, contact.normal, Color.white);
		}
	}

	// Destroy everything that enters the trigger
	void OnTriggerEnter ( Collider other) {
		Debug.Log("Trigger enter! hat collided with: " + other.ToString());

		//TODO: Attach the hat to the player ball.
		//With the hat the ball can destroy obstacles.


		if (other.gameObject.tag == "Player") {
			attachedPlayerObject = other.gameObject;
		}
	}
}
