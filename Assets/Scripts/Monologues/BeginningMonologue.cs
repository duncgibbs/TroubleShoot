using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BeginningMonologue : MonoBehaviour {

	public Text textComponent;
	private float waitTime;
	
	void Start () {
		textComponent = GetComponent<Text> ();
		waitTime = 0.15f * textComponent.text.Length;
		StartCoroutine (FadeMessage ());
	}
	
	IEnumerator FadeMessage() {
		float secs = (float)GetComponent<Text> ().text.Length * 0.15f;
		yield return new WaitForSeconds(secs);
		GetComponent<Text> ().enabled = false;
	}
}
