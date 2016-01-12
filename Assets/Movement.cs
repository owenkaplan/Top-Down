using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	public Rigidbody2D phys;
	public float speed = 2.0f;
	// Use this for initialization
	void Start () {
		phys = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		float xAxis = Input.GetAxis ("Horizontal");
		float yAxis = Input.GetAxis ("Vertical");
		Vector2 moveDir = new Vector2(xAxis,yAxis); 
		phys.velocity = moveDir.normalized * speed;

	}	
}
