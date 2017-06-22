using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
	bool gameEnded = false;
	public GameObject completeLevelUI;
	public void endGame(){
		if(gameEnded==false){
			
			gameEnded = true;
			Debug.Log("Dead..LMAO");
			Invoke("Restart",2f);
		}
		
	}
	void Restart(){
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

	public void CompleteLevel(){
		completeLevelUI.SetActive(true);
	}
}
