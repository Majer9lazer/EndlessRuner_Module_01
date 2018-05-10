using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{

    public Transform player;
	
	// Update is called once per frame
	void Update ()
	{
	    Vector3 playerPosition = player.position;
	    playerPosition.z -= 10.0f;
	    playerPosition.y += 2.0f;

	    transform.position = playerPosition;
	}
}
