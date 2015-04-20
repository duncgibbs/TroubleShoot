using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class OpeningMonologue : MonoBehaviour {

	int line = 1;

	void Update() {
		string textName = "Text" + line.ToString();

		GameObject canvas = GameObject.FindGameObjectWithTag ("MainCamera");
		Text textObj = canvas.transform.Find (textName).GetComponent<Text>();
		textObj.enabled = true;

		if (Input.GetKeyDown ("space")) {
			textObj.enabled = false;
			line++;
		}

		if (line > 3) {
			Application.LoadLevel(2);
		}
	}

	void Start() {
		GetComponent<Canvas> ().transform.GetChild(0).GetComponent<RectTransform>().sizeDelta = new Vector2(GetComponent<Canvas> ().GetComponent<RectTransform>().sizeDelta.x, GetComponent<Canvas> ().GetComponent<RectTransform>().sizeDelta.y);
	}
}
