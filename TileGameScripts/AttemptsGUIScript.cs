using UnityEngine;
using System.Collections;

public class AttemptsGUIScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//DontDestroyOnLoad (gameObject);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Add(){
		attempts++;
	}

	int attempts = 0;
	public GUIStyle font;

	void OnGUI(){
		GUI.Box(new Rect(45,10,100,90), "Attempts: " + attempts, font);
	}
}
