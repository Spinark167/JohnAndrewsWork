using UnityEngine;
using System.Collections;

public class TileScript13 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		GameObject tile = GameObject.Find ("Tile13");
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
		
		GameObject LightsObject = GameObject.Find ("OuterLight13"); 
		LightsOnOff lightsScript = LightsObject.GetComponent<LightsOnOff> ();
		
		GameObject LightsObjects = GameObject.Find ("InnerLight13"); 
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
