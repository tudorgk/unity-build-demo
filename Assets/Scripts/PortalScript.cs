using UnityEngine;
using System.Collections;

public class PortalScript : MonoBehaviour {

	public GameObject target;

	void OnTriggerEnter( Collider other ){
		if (other.gameObject.tag == "Player") {
			other.transform.position = target.transform.position + Vector3.up;
		}
	}

}
