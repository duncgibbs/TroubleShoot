using UnityEngine;
using System.Collections;

public class MonsterMovement : MonoBehaviour {

	public bool isDead;
	public int xFacing = 1;

	public Sprite aliveSprite;
	public Sprite deadSprite;
	
	void Start() {
		isDead = false;
	}
	
	void Update() {
		if (Random.Range (1, 100) == 50) {
			xFacing *= -1;
		}
		if (!isDead) {
			GetComponent<Rigidbody2D> ().AddForce (new Vector2 (10f * xFacing, 8f), ForceMode2D.Impulse);
		}
	}

	public void NewFacing(int newFace) {
		xFacing = newFace;
	}

	public void KillMonster() {
		gameObject.layer = 9;
		GetComponent<SpriteRenderer> ().sprite = deadSprite;
		isDead = true;
	}
}
