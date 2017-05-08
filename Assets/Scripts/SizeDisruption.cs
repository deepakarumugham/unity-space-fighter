using UnityEngine;
using System.Collections;

public class SizeDisruption : MonoBehaviour {

	// Use this for initialization
	void Start () {
		transform.localScale = new Vector3 (20f, 20f , 20f);
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.localScale.x >= 19f) {
			float value = transform.localScale.x - 1f;
			transform.localScale = new Vector3 (value, value, value);
		} else {
			transform.localScale = new Vector3 (20f, 20f , 20f);
		}
	}
}
