﻿using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CharacterMover : MonoBehaviour
{

	private CharacterController controller;
	
	public float Gravity = 9.81f;
	public float MoveSpeed = 3.0f;
	public float JumpSpeed = 3.0f;
	private Vector3 position;
	private Vector3 rotation;
	
	void Start ()
	{

		controller = GetComponent<CharacterController>();

	}
	
	void Update ()
	{

		if (controller.isGrounded)
		{
			position.Set(MoveSpeed*Input.GetAxis("Horizontal"), 0, 0);
			position = transform.TransformDirection(position);
			
			if (Input.GetButton("Jump"))
			{
				position.y = JumpSpeed;
			}
		}

		position.y -= Gravity * Time.deltaTime;
		controller.Move(position * Time.deltaTime);

	}
}
