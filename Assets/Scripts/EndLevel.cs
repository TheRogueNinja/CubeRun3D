using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevel : MonoBehaviour {
	public GameManager gameMan;
	void OnTriggerEnter(){
		gameMan.CompleteLevel();
		
	}

}
