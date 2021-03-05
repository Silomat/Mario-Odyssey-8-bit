using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gegner : MonoBehaviour {
	private bool MovingRight;
	public float speed;
	public Transform GroundDetection;
	public float distance;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector2.right * speed * Time.deltaTime);
		RaycastHit2D GroundInfo = Physics2D.Raycast (GroundDetection.position, Vector2.down, distance);
		if (GroundInfo.collider == false) {
			if (MovingRight == true) {
				transform.eulerAngles = new Vector3 (0, -180, 0);
				MovingRight = false;
			} else {
				transform.eulerAngles = new Vector3 (0, 0, 0);
				MovingRight = true;
			}

		}
	}
}
