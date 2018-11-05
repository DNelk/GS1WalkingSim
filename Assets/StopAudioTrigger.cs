using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class StopAudioTrigger : MonoBehaviour
{
	public AudioSource source; //clip to stop

	private float d = 0.0f; //duration
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter(Collider other)
	{
		Renderer renderer = GetComponent<Renderer>();
		renderer.material.color = Color.green;
		Debug.Log(source.isPlaying);
		if(source.isPlaying)
			source.Stop();
	}
}
