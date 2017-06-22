using UnityEngine;

public class PlayerMovements : MonoBehaviour {

	public Rigidbody rbcube;
	public float movSpeedForw;
	public float movSpeedSide;
	// Update is called once per frame
	void FixedUpdate () {
		rbcube.AddForce(0,0,movSpeedForw*Time.deltaTime);
		if(Input.GetKey("a")){
			rbcube.AddForce(-movSpeedSide*Time.deltaTime,0,0,ForceMode.VelocityChange);			
		}
		if(Input.GetKey("d")){
			rbcube.AddForce(movSpeedSide*Time.deltaTime,0,0,ForceMode.VelocityChange);			
		}
		if(rbcube.position.y <= -1f)
		{
			GetComponent<PlayerMovements>().enabled=false;
			FindObjectOfType<GameManager>().endGame();
		}				
	
	}
}
