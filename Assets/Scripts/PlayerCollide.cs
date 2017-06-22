using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollide : MonoBehaviour {
public PlayerMovements mov;
void OnCollisionEnter(Collision col){
		if(col.collider.tag=="Obstacle"){
			mov.enabled = false;
			FindObjectOfType<GameManager>().endGame();
		}
	}
}
