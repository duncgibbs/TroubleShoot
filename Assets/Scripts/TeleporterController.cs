using UnityEngine;
using System.Collections;

public class TeleporterController : MonoBehaviour {

	public GameObject teleporterEntrance;
	public GameObject teleporterExit;

	void OnTriggerEnter2D(Collider2D col) {
		if (col.gameObject.layer != 10) {
			col.transform.position = teleporterExit.transform.position;
		} else {
			Physics2D.IgnoreCollision (col, transform.GetComponent<BoxCollider2D>());
		}
	}
}
