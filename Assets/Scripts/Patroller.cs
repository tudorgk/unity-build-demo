using UnityEngine;
using System.Collections;

public class Patroller : MonoBehaviour {

	public float speed;

	// Use this for initialization
	void Start () {
		StartCoroutine(Movement(transform.position + Vector3.forward*5));
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator Movement(Vector3 target){

		while(true){
			yield return null;
	

		var nextTarget = transform.position;

		while(Vector3.Distance(target, transform.position) >0.2){
			yield return new WaitForEndOfFrame();

			var newPosition = Vector3.MoveTowards(transform.position, target,2 * Time.deltaTime);
			transform.position = newPosition;

		}

		yield return StartCoroutine(WaitForAnyBall());

		while(Vector3.Distance(nextTarget, transform.position) >0.2){
			yield return new WaitForEndOfFrame();
			
			var newPosition = Vector3.MoveTowards(transform.position, nextTarget,2 * Time.deltaTime);
			transform.position = newPosition;
			
		}
		
	}
	}

	IEnumerator WaitForAnyBall(){
		while (true){
			yield return null;		
		
			var players = GameObject.FindGameObjectsWithTag("Player");

			foreach ( var player in players ){
				if (Vector3.Distance(player.transform.position, transform.position) < 2){
					yield break;
				}
			}
		}

	}

}
