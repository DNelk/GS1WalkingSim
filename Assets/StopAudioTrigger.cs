using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class StopAudioTrigger : MonoBehaviour
{
	public AudioSource source; //clip to stop

	public float duration = 0.5f; //duration
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter(Collider other)
	{
		if (source.isPlaying)
		{
			source.DOFade(0.0f, duration).OnComplete(ResetAudio);
		}
		else
		{
			source.Play();
			source.DOFade(1.0f, duration);
		}
			
	}

	private void ResetAudio()
	{
		source.Stop();
	}
}
