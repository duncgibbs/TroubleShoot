using UnityEngine;
using System.Collections;

public class SwitchController : MonoBehaviour {
	

	void OnTriggerEnter2D(Collider2D col) {
		if (col.gameObject.tag == "Player" || col.gameObject.tag == "Corpse") {
			transform.GetComponent<Renderer>().material.color = Color.white;
			GameObject.Find ("Elevator").GetComponent<Rigidbody2D>().isKinematic = false;
			GameObject.Find ("Elevator").GetComponent<Rigidbody2D>().gravityScale = -2;
		}
	}

	void OnTriggerExit2D(Collider2D col) {
		if (col.gameObject.tag == "Player" || col.gameObject.tag == "Corpse") {
			transform.GetComponent<Renderer>().material.color = Color.black;
			GameObject.Find ("Elevator").GetComponent<Rigidbody2D>().gravityScale = 0;
		}
	}

	void TriggerEvent() {
		//Event to trigger
	}
}
