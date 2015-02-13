using UnityEngine;
using System.Collections;

public class AttemptsCounterScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (gameObject);
		//Increase ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Add(){
		attempts++;
	}

	int attempts = 0;

	public void Increase() {
		for (int i = 1; i <= attempts; i++) {
			GameObject att = GameObject.Find("AttemptsGUI");
			AttemptsGUIScript attScript = att.GetComponent<AttemptsGUIScript>();
			attScript.Add();
		}
	}

	public void Subtract() {
		while (attempts > 0) {
			attempts--;
		};
	}
}
