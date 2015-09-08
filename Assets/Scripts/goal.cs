using UnityEngine;
using System.Collections;

public class goal : MonoBehaviour {

	void OnTriggerEnter( Collider other ){
		if (other.gameObject.tag == "Player") {
			Instantiate (Resources.Load ("hearts"), this.transform.position , Quaternion.identity);
			StartCoroutine(goToNextLevel());
		}
	}

	IEnumerator goToNextLevel(){
		yield return new WaitForSeconds(2.0f);

		//Application.LoadLevel(Application.loadedLevel+1);  // Load next level
		Application.LoadLevel(Application.loadedLevel);   // ReLoad current level
	}
}
