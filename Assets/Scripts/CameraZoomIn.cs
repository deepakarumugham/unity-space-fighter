using UnityEngine;
using System.Collections;

public class CameraZoomIn : MonoBehaviour {
	public float speed = 5f;
	public int cameraStartZPos = -100;
	public GameObject mainMenu;
	public GameObject lostPlanet;
	public GameObject explosion;
	public GameObject source;
	public GameObject bluePlanet;
	public GameObject mixBluePlanet;

	// Use this for initialization
	void Start () {
		if(mainMenu != null){
			mainMenu.SetActive(false);
		}
		if(lostPlanet != null){
			lostPlanet.SetActive(false);
		}
		if(explosion != null){
			explosion.SetActive(false);
		}

		if(source != null){
			source.SetActive(false);
		}

		if(bluePlanet != null){
			bluePlanet.SetActive(false);
		}

		if(mixBluePlanet != null){
			mixBluePlanet.SetActive(false);
		}
		this.transform.position = new Vector3 (0, 0, cameraStartZPos);
	}
	
	// Update is called once per frame
	void Update () {
		if (this.transform.position.z <= -50) {
			transform.Translate (Vector3.forward * Time.deltaTime * speed);
			if(this.transform.position.z >= -1150){
				if(source != null){
					source.SetActive(true);
					//transform.Translate (Vector3.forward * (Time.deltaTime / 10));
				}
			}

			if(this.transform.position.z >= -950){
				if(bluePlanet != null && mixBluePlanet != null){
					bluePlanet.SetActive(true);
					mixBluePlanet.SetActive(true);
					transform.Translate (Vector3.forward * Time.deltaTime * speed);
				}
			}

		} else {
			if(explosion != null){
				explosion.SetActive(true);
			}

			if(mainMenu != null){
				mainMenu.SetActive(true);
			}
			if(lostPlanet != null){
				lostPlanet.SetActive(true);
			}

		}
	}
}
