using UnityEngine;
using System.Collections;

public class TileScriptStart : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//SpawnBall ();
	}

	//public GameObject ballPrefab;
	//GameObject attachedBall = null;

	//public void SpawnBall() {
		//attachedBall = (GameObject)Instantiate (ballPrefab, transform.position + new Vector3 (0, 1f, 0), Quaternion.identity);  
	//}
	
	// Update is called once per frame
	void Update () {
		GameObject tile = GameObject.Find ("TileStart");
		float tilePositionx = tile.transform.position.x;
		float tilePositionz = tile.transform.position.z;
		
		GameObject ball = GameObject.Find ("Ball");
		float ballPositionx = ball.transform.position.x; 
		float ballPositionz = ball.transform.position.z; 
		
		float distancex = ballPositionx - tilePositionx;
		float distancez = ballPositionz - tilePositionz;
		
		if (distancex < 0) {
			distancex = distancex * -1;
		}
		if (distancez < 0) {
			distancez = distancez * -1;
		}
		
		GameObject LightsObject = GameObject.Find ("OuterLightStart"); 
		LightsOnOff lightsScript = LightsObject.GetComponent<LightsOnOff> ();
		
		GameObject LightsObjects = GameObject.Find ("InnerLightStart"); 
		LightsOnOff lightsScripts = LightsObjects.GetComponent<LightsOnOff> ();
		
		if (distancex <= 1 && distancez <=1) {
			lightsScript.On ();
			lightsScripts.On ();
		} else {
			lightsScript.Off ();
			lightsScripts.Off ();
		}
	}
}
