using UnityEngine;
using System.Collections;

public class Cell : MonoBehaviour {

	public Camera ourCamera;
	private Vector3 mouseLocation;
	public float speed;
	private Vector3 direction;

	// Use this for initialization
	void Start () {
	//  if ourCamera is null then set the MainCamera to the variable ourCamera
		if(ourCamera == null)
		{
			ourCamera = Camera.main;
		}
	}
	
	// Update is called once per frame
	void Update () {
		mouseLocation = Input.mousePosition;
		mouseLocation.z = 10;
		direction = ourCamera.ScreenToWorldPoint(mouseLocation);
		transform.position = Vector3.MoveTowards(transform.position, direction, speed * Time.deltaTime);
	}
}
