using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowFix : MonoBehaviour
{

	public Vector3 Movement;

	// Use this for initialization
	void Start ()
	{
		//transform.Translate(Movement);
		transform.Rotate(Movement);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
