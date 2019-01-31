using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
	[SerializeField] GameObject player;
	[SerializeField] float scrollspeed = 50f;
	private Vector3 pos;

	// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
		pos = player.transform.position;
		transform.position = new Vector3(pos.x, transform.position.y, pos.z);
		transform.LookAt(pos);

		if (transform.position.y != 0) {

			transform.position = new Vector3(pos.x, Input.GetAxis("Mouse ScrollWheel")* scrollspeed, pos.z);
		}
    }
}
