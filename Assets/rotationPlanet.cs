using UnityEngine;
using System.Collections;

public class rotationPlanet : MonoBehaviour {
	private float AngularVelocity = 0;
	// Use this for initialization
	void Start () {
		AngularVelocity = Random.Range(-45,45);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(0,AngularVelocity*Time.deltaTime,0);
	}
}
