using UnityEngine;
using System.Collections;

public class BallMovement : MonoBehaviour {

	public AudioClip[] blipAudio;

	// Use this for initialization
	void Start () {
	
	}

	public KeyCode addSpeed;
	//bool fish = true;
	float Timer = 5f;

	// Update is called once per frame
	void Update () {
		Timer -= Time.deltaTime;

		if (Input.GetKey (addSpeed) && (Timer <= 0)) {
			SpeedUp();
		};
	}

	void SpeedUp() {
		//fish = false;
		rigidbody.AddForce(0, -200f, 0);
		//yield return new WaitForSeconds(5);
		//fish = true;

		Timer = 5f;
	}

	public void Die() {
		Destroy (gameObject);
		GameObject paddleObject = GameObject.Find ("Paddle");
		PaddleScript paddleScript = paddleObject.GetComponent<PaddleScript>();
		paddleScript.SpawnBall();
		GameObject guiScoreObject = GameObject.Find ("GUILives");
		GUILives guiScoreScript = guiScoreObject.GetComponent<GUILives> ();
		guiScoreScript.Loss ();
	}
	void OnCollisionEnter(Collision collision) {
		AudioSource.PlayClipAtPoint (blipAudio[ Random.Range(0, blipAudio.Length) ], transform.position, .15f);
		//There could be a third parameter for the PlayClipAtPoint and it represents the volume of the audio file so 
		//.5f would play the clip at half the volume
		}
}
