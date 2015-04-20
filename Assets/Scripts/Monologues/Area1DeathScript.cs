using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Area1DeathScript : MonoBehaviour {

	public bool oneTime = false;
	public bool twoTime = false;
	public bool done = false;

	void Update() {
		if (Input.GetKeyDown ("right shift") || Input.GetKeyDown ("left shift")) {
			if (!oneTime) {
				GameObject.Find("Opening Dialog").SetActive(false);
				GameObject onDeath = GameObject.Find("On death");
				onDeath.transform.GetChild(0).gameObject.SetActive(true);
				StartCoroutine(FadeMessage(onDeath.transform.GetChild(0).GetComponent<Text>()));
				oneTime = true;
			} else {
				GameObject onDeath = GameObject.Find("On death");
				onDeath.transform.GetChild(0).gameObject.SetActive(false);
				onDeath.transform.GetChild(1).gameObject.SetActive(true);
				StartCoroutine(FadeMessage(onDeath.transform.GetChild(1).GetComponent<Text>()));
				twoTime = true;
			}
		}
		if (done) {
			gameObject.SetActive(false);
		}
	}

	IEnumerator FadeMessage(Text comp) {
		float secs = (float)comp.text.Length * 0.15f;
		comp.enabled = true;
		yield return new WaitForSeconds(secs);
		comp.enabled = false;
		if (twoTime) {
			done = true;
		}
	}
}
