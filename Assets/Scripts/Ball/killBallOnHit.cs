using UnityEngine;
using System.Collections;

public class killBallOnHit : MonoBehaviour {

	void OnCollisionEnter( Collision other ){
		if (other.gameObject.tag == "Player") {

			//If the player has an imunity hat
			hitHat hitHatScript = (hitHat)other.gameObject.GetComponent("hitHat");
			if(hitHat.hasHat(other.gameObject)){
				//Should destroy self	
				Destroy(GameObject.FindGameObjectWithTag("ImunityHat"));
				hitHat.attachedPlayerObject = null;
				Destroy(gameObject);

				return;
			}

			//Explode
			Instantiate (Resources.Load ("Explosion"), this.transform.position , Quaternion.identity);

			Destroy (other.gameObject);
			Debug.Log(GameObject.FindGameObjectsWithTag("Player").Length);
			if ( GameObject.FindGameObjectsWithTag("Player").Length < 2 )
				Application.LoadLevel(Application.loadedLevel);
		}
	}

}
