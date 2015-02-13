using UnityEngine;
using System.Collections;

public class PowerUpScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	public int spinx;
	public int spiny;
	public int spinz;

	// Update is called once per frame
	void Update () {
		transform.Rotate (spinx, spiny, spinz);
	}

	void OnCollisionEnter(Collision collision) {
		Destroy (gameObject);
		GameObject points = GameObject.Find ("GUIScore");
		GUIScore guiScore = points.GetComponent<GUIScore> ();
		guiScore.Add ();
		guiScore.Add ();
		guiScore.Add ();
		guiScore.Add ();
		guiScore.Add ();
	}
}
