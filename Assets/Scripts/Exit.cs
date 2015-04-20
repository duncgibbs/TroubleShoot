using UnityEngine;
using System.Collections;

public class Exit : MonoBehaviour {

	private bool isVictorious = false;
	public int level;

	void OnLevelWasLoaded(int level) {
		this.level = level + 1;
	}

	void OnCollisionEnter2D(Collision2D col) {
		if (col.gameObject.name == "Player") {
			isVictorious = true;
			col.gameObject.GetComponent<Player> ().enabled = false;
			StartCoroutine (LevelClear ());
		} else if (col.gameObject.tag == "Corpse") {
			col.gameObject.SetActive(false);
		}
	}

	IEnumerator LevelClear() {
		yield return new WaitForSeconds (3);
		Application.LoadLevel(level);
	}

	void OnGUI() {
		if (isVictorious) {
			GUI.Label (new Rect (Screen.width / 2 - 200, Screen.height / 2 - 50, 400, 100), "Level::clear();");
		}
	}
}
