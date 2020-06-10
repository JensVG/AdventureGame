using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    NavMeshAgent nm;
    public Transform target;
    void Start()
    {
        nm = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        nm.SetDestination(target.position);
    }
}
