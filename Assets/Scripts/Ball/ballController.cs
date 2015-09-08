using UnityEngine;
using System.Collections;

public class ballController : MonoBehaviour {

	Camera camera;


	void Start () {
		camera = GameObject.Find("Main Camera").GetComponent<Camera>();
	}
	
	void FixedUpdate () {
		if(Input.GetMouseButton(0)) {
			Ray ray = camera.ScreenPointToRay( Input.mousePosition );
			RaycastHit hit;
			Physics.Raycast( ray, out hit );
			float worldPos = -ray.origin.y / ray.direction.y;
			GetComponent<Rigidbody>().AddForce((ray.GetPoint( worldPos ) - transform.position)*10);
		}
	
		if(gameObject.transform.position.y > 2){
			Vector3 temp = transform.position;
			temp.y = 2;
			gameObject.transform.position=temp;
		}
	}
}
