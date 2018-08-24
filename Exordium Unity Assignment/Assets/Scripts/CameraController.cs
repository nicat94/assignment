using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public GameObject FollowTarget;
	private Vector3 _targetPos;
	public float MoveSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		_targetPos = new Vector3(FollowTarget.transform.position.x, FollowTarget.transform.position.y, transform.position.z);
		transform.position = Vector3.Lerp(transform.position, _targetPos, MoveSpeed * Time.deltaTime);
	}
}
