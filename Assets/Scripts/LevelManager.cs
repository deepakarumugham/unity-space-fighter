using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	void Start(){
		Screen.SetResolution (800, 600, true, 60);
	}

	public void LoadLevel(string name){
		Screen.SetResolution (800, 600, true, 60);
		Debug.Log ("New Level load: " + name);
		Application.LoadLevel (name);
	}

	public void QuitRequest(){
		Debug.Log ("Quit requested");
		Application.Quit ();
	}

}
