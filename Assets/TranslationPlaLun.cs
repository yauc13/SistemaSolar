using UnityEngine;
using System.Collections;

public class TranslationPlaLun : MonoBehaviour {
	private float AngularVelocity = 0;
	public GameObject MoonAround;
	public GameObject MoonAround2;
	private int state;
	// Use this for initialization
	void Start () {
		AngularVelocity = Random.Range(-80,80);
		if(MoonAround!=null){
			state  = 0;
		}
		else{
			state = 1;
		}
	}
	void Update () {
		switch(state){
		case 0:
			transform.RotateAround(Vector3.zero,Vector3.up,AngularVelocity*Time.deltaTime);
			
			MoonAround.transform.RotateAround(transform.localPosition,Vector3.up,8*Time.deltaTime);
			MoonAround2.transform.RotateAround(transform.localPosition,Vector3.up,2*Time.deltaTime);
			break;
		case 1:
			transform.RotateAround(Vector3.zero,Vector3.up,AngularVelocity*Time.deltaTime);
			break;
		}
		
	}
}
