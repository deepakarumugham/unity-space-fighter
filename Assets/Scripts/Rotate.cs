using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {

	public float rotateSpeed = 5f;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(Vector3.down * Time.deltaTime * rotateSpeed);
	}
}
