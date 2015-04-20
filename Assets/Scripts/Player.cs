using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Controller2D))]
public class Player : MonoBehaviour {
	
	public float jumpHeight = 4;
	public float timeToJumpApex = .4f;
	public float accelerationTimeAirborne = .2f;
	public float accelerationTimeGrounded = .1f;
	public float moveSpeed = 6;
	
	public float gravity;
	float jumpVelocity;
	//Vector2 input;
	public Vector3 velocity;
	public bool allowedToMove = true;
	public float velocityXSmoothing;
	
	public Controller2D controller;

	void Start() {
		controller = GetComponent<Controller2D> ();
		
		gravity = -(2 * jumpHeight) / Mathf.Pow (timeToJumpApex, 2);
		jumpVelocity = Mathf.Abs(gravity) * timeToJumpApex;
	}
	
	void Update() {

		if (allowedToMove) {
			if (Input.GetKeyDown ("right shift") || Input.GetKeyDown ("left shift")) {
				StartCoroutine (controller.KillPlayer (velocity.x));
				controller.isRespawning = true;
			}

			if (controller.collisions.above || controller.collisions.below) {
				velocity.y = 0;
			}
			
			if (Input.GetKeyDown (KeyCode.Space) && controller.collisions.below) {
				Jump ();
			}
		}

		Vector2 input = allowedToMove ? new Vector2 (Input.GetAxisRaw ("Horizontal"), Input.GetAxisRaw ("Vertical")) : new Vector2(0f,0f);
		float targetVelocityX = allowedToMove ? input.x * moveSpeed : 0;
		velocity.x = Mathf.SmoothDamp (velocity.x, targetVelocityX, ref velocityXSmoothing, (controller.collisions.below) ? accelerationTimeGrounded : accelerationTimeAirborne);
		velocity.y += gravity * Time.deltaTime;
		GameCamera cam = Camera.main.GetComponent<GameCamera> ();
		if (velocity.y < -15) {
			velocity.y = -15;
			cam.dampTime = cam.dampTime > 0 ? cam.dampTime - .01f : cam.dampTime = 0;
		} else {
			Camera.main.GetComponent<GameCamera> ().dampTime = 0.15f;
		}
		controller.Move (velocity * Time.deltaTime);
	}

	public void Jump() {
		gravity = -(2 * jumpHeight) / Mathf.Pow (timeToJumpApex, 2);
		jumpVelocity = Mathf.Abs(gravity) * timeToJumpApex;
		velocity.y = jumpVelocity;
		controller.Move (velocity * Time.deltaTime);
	}
}