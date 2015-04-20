using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {
	
	void OnTriggerEnter2D(Collider2D col) {
		GetComponent<Renderer> ().material.color = Color.green;
		col.GetComponent<SpawnController> ().NewSpawnPoint (transform.position);
	}
}
