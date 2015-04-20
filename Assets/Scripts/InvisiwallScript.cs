using UnityEngine;
using System.Collections;

public class InvisiwallScript : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Corpse"){
			Destroy(col.gameObject);
		}
	}
}
