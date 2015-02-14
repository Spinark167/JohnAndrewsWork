using UnityEngine;
using System.Collections;

public class DeadAI7 : MonoBehaviour {

	//float timer = 1.5f;
	//bool freeze = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame

	void FixedUpdate () {
		//timer -= .02f;
	}

	//public GameObject prefab;
	//GameObject attachedFace = null;

	void OnCollisionEnter(Collision other) {
		if (other.gameObject.tag == "Bullet") {
			gameObject.GetComponent<AILookingScript>().enabled = false;
			rigidbody.constraints = RigidbodyConstraints.None;
			rigidbody.useGravity = true;
			GameObject face = GameObject.Find ("AIFace7");
			face.gameObject.GetComponent<MeshRenderer>().enabled = false;
			//transform.localScale.x = .25f;
			//transform.localScale.y = .25f;
			//transform.localScale.z = .25f;
			transform.localScale = new Vector3( .25f, .25f, .25f );
			//attachedFace = (GameObject)Instantiate(prefab, face.transform.position, face.transform.rotation);
			//Destroy(face.gameObject);
			//attachedFace.transform.parent = gameObject.transform.parent;
		}
		/*if (other.gameObject.tag == "Ground") {
			timer = 2;
			freeze = true;
		}*/
	}

	void Update () {
		/*if (timer <= 0 && freeze == true) {
			rigidbody.isKinematic = true;
		}*/

		//GameObject face = GameObject.Find ("AIFaceSpecial");
		//attachedFace.transform.position = face.transform.position;
		//attachedFace.transform.rotation = face.transform.rotation;
	}
}
