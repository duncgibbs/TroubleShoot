using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Credits : MonoBehaviour {
	
	void Update() {
		string textName = "Text1";

		GetComponent<Canvas> ().transform.GetChild(0).GetComponent<RectTransform>().sizeDelta = new Vector2(GetComponent<Canvas> ().GetComponent<RectTransform>().sizeDelta.x, GetComponent<Canvas> ().GetComponent<RectTransform>().sizeDelta.y);
		
		GameObject canvas = GameObject.FindGameObjectWithTag ("MainCamera");
		Text textObj = canvas.transform.Find (textName).GetComponent<Text>();
		textObj.enabled = true;
		
		if (Input.GetKeyDown ("space")) {
			Application.LoadLevel(0);
		}
	}
}
