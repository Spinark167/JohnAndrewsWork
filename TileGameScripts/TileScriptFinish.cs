using UnityEngine;
using System.Collections;

public class TileScriptFinish : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		GameObject tile = GameObject.Find ("TileFinish");
		float tilePositionx = tile.transform.position.x;
		float tilePositionz = tile.transform.position.z;
		float tilePositiony = tile.transform.position.y;
		
		GameObject ball = GameObject.Find ("Ball");
		float ballPositionx = ball.transform.position.x; 
		float ballPositionz = ball.transform.position.z; 
		float ballPositiony = ball.transform.position.y;
		
		float distancex = ballPositionx - tilePositionx;
		float distancez = ballPositionz - tilePositionz;
		float distancey = ballPositiony - tilePositiony;
		
		if (distancex < 0) {
			distancex = distancex * -1;
		}
		if (distancez < 0) {
			distancez = distancez * -1;
		}
		if (distancey < 0) {
			distancey = distancey * -1;
		}
		
		GameObject LightsObject = GameObject.Find ("OuterLightFinish"); 
		LightsOnOff lightsScript = LightsObject.GetComponent<LightsOnOff> ();
		
		GameObject LightsObjects = GameObject.Find ("InnerLightFinish"); 
		LightsOnOff lightsScripts = LightsObjects.GetComponent<LightsOnOff> ();
		
		if (distancex <= 1 && distancez <= 1 ) {
			lightsScript.On ();
			lightsScripts.On ();

			if(distancey <= .7) {
			Application.LoadLevel("TGLv2");
			
			GameObject attCount = GameObject.Find ("AttemptsCounter");
			AttemptsCounterScript attCountScr = attCount.GetComponent<AttemptsCounterScript> ();
			attCountScr.Subtract ();
			}

		} else {
			lightsScript.Off ();
			lightsScripts.Off ();
		}
	}
}
