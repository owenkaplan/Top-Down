using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	public Rigidbody2D phys;
	public float speed = 2.0f;
	public float speedCap = 100f;
	//Vector3 lastDeltaPos = Vector3.zero;
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


		phys.AddForce (deltaPos, ForceMode2D.Force);
		Vector2 velocity = phys.velocity;
		if (velocity.magnitude >= speedCap) {
			phys.velocity = velocity.normalized * speedCap;
		}

		if (Input.GetKey (KeyCode.R)) {
			Application.LoadLevel(0);
		}

	}
}
