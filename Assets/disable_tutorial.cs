using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disable_tutorial : MonoBehaviour {
	
	public GameObject myObject;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider collider)
	{
		myObject.SetActive(false);

	}
}
