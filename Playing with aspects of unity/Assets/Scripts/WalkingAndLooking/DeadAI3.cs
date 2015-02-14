using UnityEngine;
using System.Collections;

public class DeadAI3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision other) {
		if (other.gameObject.tag == "Bullet") {
			gameObject.GetComponent<AILookingScript>().enabled = false;
			rigidbody.constraints = RigidbodyConstraints.None;
			rigidbody.useGravity = true;
			GameObject face = GameObject.Find ("AIFace3");
			face.gameObject.GetComponent<MeshRenderer>().enabled = false;
			transform.localScale = new Vector3( .25f, .25f, .25f );
		}
	}
}
