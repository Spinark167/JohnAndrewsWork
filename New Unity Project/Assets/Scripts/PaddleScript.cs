using UnityEngine;
using System.Collections;

public class PaddleScript : MonoBehaviour {

	public float paddlespeed = 10f;
	public GameObject ballPrefab;

	GameObject attachedBall = null;

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (gameObject);
		SpawnBall ();
	}

	public void SpawnBall() {
		attachedBall = (GameObject)Instantiate (ballPrefab, transform.position + new Vector3 (0, 1f, 0), Quaternion.identity); 

	}

	public void OnLevelWasLoaded( int level ){
		SpawnBall ();
		startforce += 75f;
		speedBonus += .1f;
	}
	
	// Update is called once per frame
	float speedBonus = 1.1f;
	float startforce = 0f;
	void Update () {
		transform.Translate (paddlespeed * Time.deltaTime * Input.GetAxis ("Horizontal") * speedBonus, 0, 0);

		if ( attachedBall )
		{
			attachedBall.rigidbody.position = transform.position + new Vector3 (0, 1f, 0); 
			if (Input.GetButtonDown ("Jump")) 
			{
				attachedBall.rigidbody.isKinematic = false;
				attachedBall.rigidbody.AddForce (300f * Input.GetAxis ("Horizontal") + 15f, 300f + startforce, 0);
				attachedBall = null;
			};
		};
		if (transform.position.x >= 7.4f) {
			transform.position = new Vector3( 7.4f, transform.position.y, transform.position.z);
		};
		if (transform.position.x <= -7.4f) {
			transform.position = new Vector3( -7.4f, transform.position.y, transform.position.z);
		};
	}

	void OnCollisionEnter( Collision col ) {
		foreach (ContactPoint contact in col.contacts) {
			if(contact.thisCollider == collider) {
				float english = contact.point.x - transform.position.x;
				contact.otherCollider.rigidbody.AddForce( 300f * english, 5f, 0);
			}
		}
	}
}