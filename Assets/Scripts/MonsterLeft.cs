using UnityEngine;
using System.Collections;

public class MonsterLeft : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D col) {
		if (!transform.GetComponentInParent<MonsterMovement> ().isDead) {
			if (col.gameObject.tag == "Corpse") {
				if (col.relativeVelocity.magnitude > 15) {
					transform.GetComponentInParent<MonsterMovement>().KillMonster();
				}
			}

			if (col.gameObject.tag == "Player") {
				StartCoroutine (col.gameObject.GetComponent<Controller2D> ().KillPlayer (-15f, 20f));
			} else if (col.gameObject.layer > 8) {
				transform.GetComponentInParent<MonsterMovement> ().NewFacing (1);
			}
		}
	}
}
