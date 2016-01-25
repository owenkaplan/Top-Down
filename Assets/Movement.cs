using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	public Rigidbody2D phys;
	public float speed = 2.0f;
	public float drift = 0.9f;
	Vector3 lastDeltaPos = Vector3.zero;
	// Use this for initialization
	void Start () {
		phys = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		/*
		float xAxis = Input.GetAxis ("Horizontal");
		float yAxis = Input.GetAxis ("Vertical");
		*/
		Vector3 deltaPos = Vector3.zero;
		if(Input.GetKey(KeyCode.LeftArrow)){
			deltaPos = deltaPos + Vector3.left * speed;
		}

		if(Input.GetKey(KeyCode.RightArrow)){
			deltaPos += Vector3.right * speed;
		}

		if(Input.GetKey(KeyCode.UpArrow)){
			deltaPos += Vector3.up * speed;
		}

		if (Input.GetKey (KeyCode.DownArrow)) {
			deltaPos += Vector3.down * speed;
		}
		/*
		if (!Input.GetKey (KeyCode.DownArrow)) {
			deltaPos = lastDeltaPos * drift;
		}
		if (!Input.GetKey (KeyCode.UpArrow)) {
			deltaPos = lastDeltaPos * drift;
		}
		if (!Input.GetKey (KeyCode.LeftArrow)) {
			deltaPos = lastDeltaPos * drift;
		}
		if (!Input.GetKey (KeyCode.RightArrow)) {
			deltaPos = lastDeltaPos * drift;
		}*/
		print (deltaPos);
		phys.AddForce (deltaPos, ForceMode2D.Force);
		lastDeltaPos = deltaPos;


	}	
}
