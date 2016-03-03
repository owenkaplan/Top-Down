using UnityEngine;
using System.Collections;

public class SeekPlayer : MonoBehaviour {
	public int MonsterSpeed = 2;
	public Rigidbody2D phys;
	public Player player;
	// Use this for initialization
	void Start () {
		phys = GetComponent<Rigidbody2D> ();
		Vector2 direction = UnityEngine.Random.insideUnitCircle;
		phys.AddForce (direction, ForceMode2D.Impulse);

	}
	
	// Update is called once per frame
	void Update () {
		Vector3 playerPos = player.transform.position;
		Vector3 myPos = transform.position;

		Vector3 deltaPos = playerPos - myPos;
		phys.AddForce (2f * deltaPos * MonsterSpeed, ForceMode2D.Force);
		if(Input.GetKeyDown(KeyCode.Space)){
			phys.AddForce(-15  * deltaPos.normalized /  deltaPos.sqrMagnitude, ForceMode2D.Impulse);
		}
	}
}
