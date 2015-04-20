using UnityEngine;
using System.Collections;

public class SpawnController : MonoBehaviour {

	public Vector3 spawnPoint;

	void Start() {
		spawnPoint = new Vector3 (0f, 0f, 0f);
	}

	public void NewSpawnPoint(Vector3 point) {
		spawnPoint = point;
		spawnPoint.y += 1;
	}
}
