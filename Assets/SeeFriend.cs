using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeeFriend : MonoBehaviour
{

	public GameObject[] ants;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other)
	{
		for (int i = 0; i < ants.Length; i++)
		{
			ants[i].transform.GetChild(1).gameObject.GetComponent<ParticleSystem>().Play();
		}
	}
}
