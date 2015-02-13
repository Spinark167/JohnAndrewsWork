using UnityEngine;
using System.Collections;

public class GUILives : MonoBehaviour {

	int lives = 3;
	public GUIStyle font;
	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (gameObject);
	}
	
	// Update is called once per frame
	void Update () {
	if (lives <= 0) {
			Application.LoadLevel("GameOverScene");
		};
	}

	void OnGUI() {
		GUI.Box(new Rect(45,10,100,90), "Lives: " + lives, font);
	}

	public void Loss() {
		lives--;
	}

	public void Gain() {
		lives++;
	}
}
