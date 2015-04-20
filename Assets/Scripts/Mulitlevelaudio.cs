using UnityEngine;
using System.Collections;

public class Mulitlevelaudio : MonoBehaviour {


	private static Mulitlevelaudio instance = null;
	
	void Awake() {
		if (instance != null && instance != this) {
			Destroy(this.gameObject);
			return;
		} else {
			instance = this;
		}
		DontDestroyOnLoad(this.gameObject);
	}
}