using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BugMovement : MonoBehaviour
{
	public float d = 2.0f; //duration

	public float speed = 2.0f;
	
	public Vector3[] route;

	private int routeIndex;

	public bool usePackVariance = false;
	// Use this for initialization
	void Start ()
	{
		routeIndex = 0;
		if (usePackVariance)
			d *= Random.Range(0.5f, 1.0f);
	}
	
	// Update is called once per frame
	void Update ()
	{
		Vector3 targetDir;
		if (routeIndex != route.Length - 1)
			targetDir = route[routeIndex + 1] - transform.position;
		else 
			targetDir = route[0] - transform.position;

		// The step size is equal to speed times frame time.
		float step = speed * Time.deltaTime;

		Vector3 newDir = Vector3.RotateTowards(transform.forward, targetDir, step, 0.0f);
		transform.rotation = Quaternion.LookRotation(newDir);
		transform.DOMove(route[routeIndex], d, false).OnComplete(UpdateRoute);
	}

	private void UpdateRoute()
	{
		if(transform.position == route[routeIndex])
		{
			if(routeIndex < route.Length-1)
				routeIndex++;
			else
			{
				routeIndex = 0;
			}
		}
		
	}
}
