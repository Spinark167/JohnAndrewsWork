using UnityEngine;
using System.Collections;

public class LifeUpScript : MonoBehaviour {

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

	void OnCollisionEnter(){
		Destroy (gameObject);

		GameObject guiLives = GameObject.Find ("GUILives");
		GUILives guiLivesScript = guiLives.GetComponent<GUILives> ();
		guiLivesScript.Gain();
	}
}
