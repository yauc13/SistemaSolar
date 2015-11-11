using UnityEngine;
using System.Collections;

public class TraslationPlanet : MonoBehaviour {
	private float AngularVelocity = 0;
	// Use this for initialization
	void Start () {
		AngularVelocity = Random.Range(-80,80);
	}
	
	// Update is called once per frame
	void Update () {
		transform.RotateAround(Vector3.zero,Vector3.up,AngularVelocity*Time.deltaTime);
	}
}
