using UnityEngine;
using System.Collections;

public class MonsterScript : MonoBehaviour {

	public bool isDead;
	public int xFacing = 1;

	void Start() {
		isDead = false;
	}

	void Update() {
		if (Random.Range (1, 100) == 50) {
			xFacing *= -1;
		}

		GetComponent<Rigidbody2D> ().AddForce (new Vector2 (10f*xFacing, 8f), ForceMode2D.Impulse);
	}

	void OnCollisionEnter2D(Collision2D col) {
		print ("here");
		if (col.gameObject.tag == "Player") {
			StartCoroutine(col.gameObject.GetComponent<Controller2D>().KillPlayer(xFacing*15f));
		} else if (col.gameObject.layer == 9) {
			xFacing *= -1;
		}
	}


}
