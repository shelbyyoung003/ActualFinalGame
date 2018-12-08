using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopInstantiate : MonoBehaviour
{

	public GameObject[] Word;
	private Vector3 position;
	public float Distance = 3;

	// Use this for initialization
	void Start () {

		for (int i = 0; i < Word.Length; i++)
		{
			Instantiate(Word[i], position, Quaternion.identity);
			position.x += Distance;
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
