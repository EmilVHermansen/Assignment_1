using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontrols : MonoBehaviour
{
	[SerializeField] float movementspeed = 1f;
	private Rigidbody rb;
	float verticalAxis;
	float horizontalAxis;
	// Start is called before the first frame update
	void Start()
	{
		rb = GetComponent<Rigidbody>();

	}

	// Update is called once per frame
	void FixedUpdate()
	{
		verticalAxis = Input.GetAxis("Vertical")*movementspeed;
		horizontalAxis = Input.GetAxis("Horizontal")*movementspeed;
		Debug.Log(verticalAxis);
		Debug.Log(horizontalAxis);


		if (Input.GetButton("Horizontal"))
		{
			rb.AddForce(Vector3.right * horizontalAxis);
		}

		if (Input.GetButton("Vertical"))
		{
			rb.AddForce(Vector3.forward* verticalAxis);

		}
	}
}
