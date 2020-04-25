using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour {
	Vector2 thrustDirection;
	const float ThrustForce = 0.2f;
	Rigidbody2D shipRB;
	float leftConst = Screen.width;
	float rightConst = Screen.width;
	float topConst = Screen.height;
	float bottomConst = Screen.height;
	Camera cam;
	Vector3 position;
	const float RotateDegreesPerSecond = 90;


	// Use this for initialization
	void Start () {
		shipRB = GetComponent<Rigidbody2D>();
		cam = Camera.main;
		leftConst = cam.ScreenToWorldPoint(new Vector3(0.0f, 0.0f, 0.0f)).x;
		rightConst = cam.ScreenToWorldPoint(new Vector3(Screen.width, 0.0f, 0.0f)).x;
		topConst = cam.ScreenToWorldPoint(new Vector3(0.0f, 0.0f, 0.0f)).y;
		bottomConst = cam.ScreenToWorldPoint(new Vector3(0.0f, Screen.height, 0.0f)).y;
	}

	void	Update()
	{
		float rotationInput = Input.GetAxis("Rotate");
		// calculate rotation amount and apply rotation
		float rotationAmount = RotateDegreesPerSecond * Time.deltaTime;
		if (rotationInput != 0)
		{
			if (rotationInput < 0)
				rotationAmount *= -1;
			transform.Rotate(Vector3.forward, rotationAmount);
			thrustDirection = new Vector2(Mathf.Cos(Mathf.Deg2Rad * transform.eulerAngles.z * (-1)),
				Mathf.Sin(Mathf.Deg2Rad * transform.eulerAngles.z * (-1)));
		}
	}

	void	FixedUpdate()
	{
		float thrustInput = Input.GetAxis("Thrust");
		if (thrustInput != 0)
			shipRB.AddForce(thrustDirection * ThrustForce, ForceMode2D.Impulse);
	}

	void OnBecameInvisible()
	{
		// check sides and moving ship
		position = transform.position;
		if (position.x < leftConst - 1.0f)
			position.x = rightConst - 0.10f;
		if (position.x > rightConst)
			position.x = leftConst - 0.10f;
		if (position.y < bottomConst - 1.0f)
			position.y = topConst + 1.0f;
		if (position.y > topConst + 1.0f)
			position.y = bottomConst - 1.0f;
		transform.position = position;
	}
}
