using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyArrows : MonoBehaviour {

	IEnumerator Start ()
	{

		yield return new WaitForSeconds(2);
		Destroy(gameObject);

	}

}
