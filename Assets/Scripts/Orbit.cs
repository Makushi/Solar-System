using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour {

	public float speed;
	public Transform pivotPoint;

	void Update () {
		transform.RotateAround (pivotPoint.position, Vector3.up, speed);
	}
}
