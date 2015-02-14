using UnityEngine;
using System.Collections;

public class FiguringOutRaycastScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float turnX = ((gameObject.transform.rotation.eulerAngles.y * Mathf.PI) / 180f);
		float turnZ = ((gameObject.transform.rotation.eulerAngles.y * Mathf.PI) / 180f);

		float rotX = Mathf.Sin (turnX);
		float rotZ = Mathf.Cos (turnZ);

		//Debug.Log (rotX);
		//Debug.Log (rotZ);

		Debug.DrawRay (transform.position, new Vector3 (1f * rotX, 0f, 1f * rotZ), Color.cyan); 
	}
}
