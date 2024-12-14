using System.Collections;
using System.Collections.Generic;
using Unity.Services.Analytics.Internal;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UIElements;
public class EnemyMovement : MonoBehaviour
{
    public Transform player;
    private NavMeshAgent navMeshAgent;
    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    public void Update()
    {
        if (player != null)
        {
            navMeshAgent.SetDestination(player.position);
        }

            
    }

    public void StopMoving()
    {
        navMeshAgent.isStopped = true;
        StopAllCoroutines();
    }
}
