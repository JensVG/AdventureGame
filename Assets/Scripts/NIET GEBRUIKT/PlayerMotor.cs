using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class PlayerMotor : MonoBehaviour
{
    NavMeshAgent Agent;
    // Start is called before the first frame update
    void Start()
    {
        Agent = GetComponent<NavMeshAgent>();
    }

    public void MoveToPoint(Vector3 Point)
    {
        Agent.SetDestination(Point);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
