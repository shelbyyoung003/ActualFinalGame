using System;
using UnityEngine;
using UnityEngine.UI;

public class UpdateImageValue : MonoBehaviour
{
	public FloatData Data;
	private Image image;
	public GameStates.States GameState;
	
	// Use this for initialization
	void Start ()
	{
		image = GetComponent<Image>();

	}
	
	// Update is called once per frame
	void Update ()
	{
		image.fillAmount = Data.Value;

		if (image.fillAmount == 0)
		{
			print("You have died.");
		}
		else
		{
			print("Keep going, Peach! We believe in you!");
		}
	}

	
}