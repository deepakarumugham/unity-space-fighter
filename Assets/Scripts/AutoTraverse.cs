using UnityEngine;
using System.Collections;

public class AutoTraverse : MonoBehaviour {

	public Transform[] wayPointList;
	int nextWayPoint = 0; 
	Transform targetWayPoint;
	const float Threshold = 1e-3f;
	public float speed = 4f;
	float angle = -45f;
	bool isFirst;

	// Use this for initialization
	void OnDrawGizmos() {
		Gizmos.color = Color.yellow;
		for(int i = 0; i < wayPointList.Length; i++){
			if(i > 0){
				Gizmos.DrawLine(wayPointList[i - 1].position, wayPointList[i].position);
			}
			Gizmos.DrawSphere(wayPointList[i].position, 2.0f);            
		}
	}

	void Start () {
		nextWayPoint = 0;
		targetWayPoint = wayPointList [0];
		isFirst = true;
	}
	
	// Update is called once per frame
	void Update () {
		// check if we have somewere to walk

		if (nextWayPoint >= this.wayPointList.Length) {
			nextWayPoint = 0;
			targetWayPoint = wayPointList [nextWayPoint];
		} 

		Move ();
	}

	void Move(){

		// move towards the target
		transform.position = Vector2.MoveTowards(transform.position, targetWayPoint.position,   speed * Time.deltaTime);

		if(transform.position == targetWayPoint.position)
		{
			nextWayPoint ++ ;
			if (nextWayPoint >= this.wayPointList.Length) {
				nextWayPoint = 0;
			}

			targetWayPoint = wayPointList[nextWayPoint];
			if(isFirst){
				isFirst = false;
			}else{
				Rotate();
			}

		}
	} 

	void Rotate()
	{
		transform.rotation = Quaternion.Euler (0, 0, -90 + transform.eulerAngles.z);
	}

	void RotateZigZag()
	{
		float AngleDeg;
		float yDiff = transform.position.y - targetWayPoint.position.y;
		if (nextWayPoint == 0) {
			AngleDeg = -180 + transform.eulerAngles.z;
		} else {
			if (yDiff > 0) {
				AngleDeg = -90 + transform.eulerAngles.z;
			} else {
				AngleDeg = 90 + transform.eulerAngles.z;
			}
		}
		

		//transform.LookAt (targetWayPoint.position);
		transform.rotation = Quaternion.Euler(0, 0, AngleDeg);
		//transform.Rotate(Vector3.forward, speed * Time.deltaTime * angle);
	}

	public float getAngleFromPoint(Vector3 firstPoint, Vector3 secondPoint) {
		
		if((secondPoint.x > firstPoint.x)) {//above 0 to 180 degrees
			
			return (Mathf.Atan2((secondPoint.x - firstPoint.x), (firstPoint.y - secondPoint.y)) * 180 / Mathf.PI);
			
		}
		else if((secondPoint.x < firstPoint.x)) {//above 180 degrees to 360/0
			
			return 360 - (Mathf.Atan2((firstPoint.x - secondPoint.x), (firstPoint.y - secondPoint.y)) * 180 / Mathf.PI);
			
		}//End if((secondPoint.x > firstPoint.x) && (secondPoint.y <= firstPoint.y))
		
		return Mathf.Atan2(0 ,0);
		
	}//End public float getAngleFromPoint(Point firstPoint, Point secondPoint)
}
