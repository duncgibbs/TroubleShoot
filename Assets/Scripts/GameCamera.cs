using UnityEngine;
using System.Collections;

public class GameCamera : MonoBehaviour {
	
	public float dampTime = 0.15f;
	private Vector3 velocity = new Vector3 (20f,20f,20f);
	public Transform target;
	
	void Update () 
	{
		if (target != null)
		{
			Camera camera = Camera.main;
			Vector3 point = camera.WorldToViewportPoint(target.localPosition);
			Vector3 delta = target.position - camera.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, point.z)); //(new Vector3(0.5, 0.5, point.z));
			Vector3 destination = transform.position + delta;
			transform.position = Vector3.SmoothDamp(transform.position, destination, ref velocity, dampTime);
		}
		
	}
}