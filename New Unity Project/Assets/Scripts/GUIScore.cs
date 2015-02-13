using UnityEngine;
using System.Collections;

public class GUIScore : MonoBehaviour {

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (gameObject);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	int score = 0;
	public GUIStyle ScoreFont;

	void OnGUI() {
		GUI.Box(new Rect( 45, 650, 100, 90), "Score: " + score, ScoreFont);
	}

	public void Add(){
		score++;
	}
}
