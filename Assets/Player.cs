using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public int points = 0;
	public void HitExplodingThing(){
		points++;
	}
}
