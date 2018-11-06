using UnityEngine;
using UnityEngine.AI;

public class FollowerAI : MonoBehaviour {

	private UnityEngine.AI.NavMeshAgent agent;
	public Transform Destination;

	void Start ()
	{
		agent = GetComponent<UnityEngine.AI.NavMeshAgent>();

	}
	
	void Update ()
	{
		if (Destination != null) agent.destination = Destination.position;
	}
}
