using UnityEngine;
using System.Collections;

public class LightsOn : MonoBehaviour {
	SpriteRenderer sprite;
	public float blinkTime = 5f;
	public float sizeMultiplier = 1;
	float timer;
	public Color color;
	public RangeAttribute range;
	// Use this for initialization
	void Start () {
		sprite = this.gameObject.GetComponentInParent (typeof(SpriteRenderer)) as SpriteRenderer;
		sprite.color = color;
		transform.localScale = new Vector3 (transform.localScale.x * sizeMultiplier, transform.localScale.y * sizeMultiplier , 0f);
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if (timer >= blinkTime) {
			if(sprite !=null){
				sprite.enabled = !(sprite.enabled);
			}
			timer = 0f;
		}
	}
}
