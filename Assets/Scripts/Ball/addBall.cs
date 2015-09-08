using UnityEngine;
using System.Collections;

public class addBall : MonoBehaviour {

	void OnTriggerEnter( Collider other ){
		Instantiate (Resources.Load ("Ball"), this.transform.position , Quaternion.identity);
		Destroy (gameObject);
	}
}
