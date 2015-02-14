using UnityEngine;
using System.Collections;

public class LightsOnOff : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	/* void OnCollisionEnter( ){
		GameObject light = GameObject.Find ("Glow");
		Light intensity = light.GetComponent<Light>();

		Debug.Log ("hit");
	} */

	public void On() {
		light.enabled = true;
	}

	public void Off() {
		light.enabled = false;
	}
}