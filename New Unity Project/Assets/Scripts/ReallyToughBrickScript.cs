using UnityEngine;
using System.Collections;

public class ReallyToughBrickScript : MonoBehaviour {

	public int brickPower = 1;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public GameObject powerUp;
	GameObject attachedPower;

	public GameObject lifeUP;
	GameObject attachedLife;
	
	
	void OnCollisionEnter( Collision col ) {
		brickPower--;
		if (brickPower <= 0) {
			Kill ();
			
			int random = Random.Range (0, 13);
			if (random == 1) {
				SpawnLifeUp();	
			}
			else if(random == 2 || random == 12) {
				SpawnPowerUp ();
			}
		}
	}
	
	void SpawnPowerUp() {
		attachedPower = (GameObject)Instantiate (powerUp, transform.position, Quaternion.identity); 
	}
	
	void SpawnLifeUp(){
		attachedLife = (GameObject)Instantiate (lifeUP, transform.position, Quaternion.identity);
	}

	void Kill() {
		Destroy (gameObject);
		GameObject guiScoreObject = GameObject.Find ("GUIScore");
		GUIScore guiScore = guiScoreObject.GetComponent<GUIScore> ();
		guiScore.Add ();
		guiScore.Add ();
		guiScore.Add ();
	}
}