using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	public Font font;

	void OnGUI() {
		GetComponent<Canvas> ().transform.GetChild(0).GetComponent<RectTransform>().sizeDelta = new Vector2(GetComponent<Canvas> ().GetComponent<RectTransform>().sizeDelta.x, GetComponent<Canvas> ().GetComponent<RectTransform>().sizeDelta.y);
		GUI.skin.font = font;
		GUI.skin.label.fontSize = 30;
		GUI.skin.label.alignment = TextAnchor.MiddleCenter;
		GUI.Label (new Rect (Screen.width / 2 - 400, Screen.height / 2 - 100, 800, 100), "TroubleShoot(yourself);");
		if (GUI.Button (new Rect (Screen.width / 2 - 100, Screen.height / 2, 200, 50), "Game::start();")) {
			Application.LoadLevel(1);
		}
	}
}
