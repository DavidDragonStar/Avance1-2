using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path : MonoBehaviour {
	Vector3 point;
	List<Vector3> path = new List<Vector3>();
	int initIndex = 0;
	int endIndex = 1; 
	float t = 0;
	
	void Start () {
        path.Add(GameObject.Find("r (0)").transform.position);
		path.Add(GameObject.Find("r (1)").transform.position);
		path.Add(GameObject.Find("r (2)").transform.position);
		path.Add(GameObject.Find("r (3)").transform.position);
		path.Add(GameObject.Find("r (4)").transform.position);
		path.Add(GameObject.Find("r (5)").transform.position);
		path.Add(GameObject.Find("r (6)").transform.position);
		path.Add(GameObject.Find("r (7)").transform.position);
        path.Add(GameObject.Find("r (8)").transform.position);
        path.Add(GameObject.Find("r (9)").transform.position);
        path.Add(GameObject.Find("r (10)").transform.position);
        path.Add(GameObject.Find("r (11)").transform.position);
    }
	
	void Update () {
		transform.position = Vector3.Lerp(path[initIndex], path[endIndex], t);
		t += 0.01f;

		if (t >= 1) {
			t = 0;
			NextPoint();
		}
	}

	void NextPoint() {
		int[] vecinos = WayPoints.points[endIndex];

		int r = Random.Range(0, vecinos.Length);
		
		initIndex = endIndex;
		endIndex = vecinos[r];
		//print(vecinos[r]);
	}
}