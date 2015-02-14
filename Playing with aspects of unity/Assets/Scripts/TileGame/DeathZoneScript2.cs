using UnityEngine;
using System.Collections;

public class DeathZoneScript2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameObject attCount = GameObject.Find ("AttemptsCounter");
		AttemptsCounterScript attCountScr = attCount.GetComponent<AttemptsCounterScript> ();
		
		attCountScr.Increase ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter( Collider other ) {
		GameObject attCount = GameObject.Find ("AttemptsCounter");
		AttemptsCounterScript attCountScr = attCount.GetComponent<AttemptsCounterScript> ();
		attCountScr.Add ();
		attCountScr.Increase ();

		BallMovement ballMovement = other.GetComponent<BallMovement> ();
		
		if (ballMovement) {
			ballMovement.Die2 ();
		}
	}
}
