using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class BounceAnim : MonoBehaviour
{
	private Vector3 initialPos;

	private bool rising;

	private float d = 0.1f;
	// Use this for initialization
	void Start () {
		initialPos = transform.position;
		rising = true;
	}
	
	// Update is called once per frame
	void Update ()
	{
		Debug.Log("Initial:" + initialPos.y + "Current:" + transform.position.y);
		if (rising)
			transform.DOMoveY(initialPos.y + 1.0f, d, false).OnComplete(SetRise);
		else
			transform.DOMoveY(initialPos.y, d, false).OnComplete(SetRise);
	}

	void SetRise()
	{
		rising = !rising;
	}
}
