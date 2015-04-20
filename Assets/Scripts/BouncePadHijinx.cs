using UnityEngine;
using System.Collections;

public class BouncePadHijinx : MonoBehaviour {

	public float bounceForce;

	void OnCollisionEnter2D(Collision2D col) {
		if (col.gameObject.tag == "Player") {
			Player p = col.gameObject.GetComponent<Player> ();
			p.jumpHeight *= 2;
			p.timeToJumpApex *= 2;
			p.Jump ();
			p.jumpHeight /= 2;
			p.timeToJumpApex /= 2;
		} else if (col.gameObject.tag == "Corpse") {
			col.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f,bounceForce*Mathf.Log(col.relativeVelocity.y)), ForceMode2D.Impulse);
		}
	}
}
