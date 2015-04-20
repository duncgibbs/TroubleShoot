using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TriggerDialog : MonoBehaviour {

	public GameObject triggerCanvas;
	public bool triggered = false;

	void OnTriggerEnter2D(Collider2D col) {
		if (col.gameObject.tag == "Player") {
			if (!triggered) {
				triggerCanvas.transform.GetChild(0).gameObject.SetActive(true);
				StartCoroutine(FadeMessage(triggerCanvas.transform.GetChild(0).GetComponent<Text>()));
			}
			triggered = true;
		}
	}

	IEnumerator FadeMessage(Text comp) {
		print (comp.text);
		float secs = (float)comp.text.Length * 0.15f;
		comp.enabled = true;
		yield return new WaitForSeconds(secs);
		comp.enabled = false;
	}
}
