using UnityEngine;
using System.Collections;

public class Shards : MonoBehaviour {
	public GameObject shard;
	public int ShardNum = 4;
	void OnCollisionEnter2D(Collision2D coll) {
		Player player; 
		player = coll.gameObject.GetComponent<Player> ();
		if (player != null) {
			GoBoom (player);
		}

	}
	void GoBoom(Player player) {
		Destroy (gameObject);
		for(int i = 0; i < ShardNum; i++) {
			Instantiate (shard, transform.position,transform.rotation);
			SeekPlayer seek = shard.GetComponent<SeekPlayer> ();
			if (seek != null) {
				seek.player = player;
			}
		}
	}
}



//Add magnitism towards player for small shards