using UnityEngine;
using System.Collections;

public class RingSpin : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnTriggerEnter() {
		//Debug.Log ("hit");
		Destroy (gameObject);
		GameObject guiScore = GameObject.Find ("ScoreGUI");
		PointsGUIScript guiScoreScript = guiScore.GetComponent<PointsGUIScript> ();
		guiScoreScript.Add ();
	}

	void FixedUpdate () {
		transform.Rotate (0f, 5f, 0f);
	}
}
