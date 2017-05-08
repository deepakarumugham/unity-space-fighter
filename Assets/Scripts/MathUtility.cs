using UnityEngine;
using System.Collections;

public class MathUtility : MonoBehaviour {
	public Transform first;
	public Transform second;
	public float result;
	// Use this for initialization
	void Start () {
		result = Vector3.Distance(first.position, second.position);
	}
	
	// Update is called once per frame
	void Update () {
		result = Vector3.Distance(first.position, second.position);
	}
}
