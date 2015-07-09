using UnityEngine;
using System.Collections;

public class Enemy_Controller : MonoBehaviour {

	public Transform target;
	public float speed = 3f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt (target.position);
		transform.Rotate (new Vector3(0,-90,0),Space.Self);


		if (Vector3.Distance(transform.position, target.position)>1f)
		                  {
			transform.Translate(new Vector3(speed* Time.deltaTime,0,0)  );
		}
		}
	}

