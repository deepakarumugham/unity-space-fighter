using UnityEngine;
using System.Collections;

public class ShakyEffect : MonoBehaviour {

	float initialX;
	void Start () {
		initialX = transform.position.x;
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x >= initialX ) {
			float value = transform.position.x - 2f;
			transform.position = new Vector3(value, transform.position.y, transform.position.z);
		} else {
			transform.position = new Vector3(initialX, transform.position.y, transform.position.z);
		}
	}
}
