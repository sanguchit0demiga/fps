using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Rendering;

public class EnemyNavigation : MonoBehaviour
{
    // Start is called before the first frame update

    public NavMeshAgent agent;
    public Transform player;
    public float detectionRange = 10f; 
    public float initialDelay = 0f;   
    public float interval = 0.5f;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        player= GameObject.FindGameObjectWithTag("Player").transform;
        
        InvokeRepeating("SetDestination", initialDelay, interval);
        
    }

  
    
    public void SetDestination()
    {
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);
        if (distanceToPlayer <= detectionRange)
        {
            agent.SetDestination(player.position);
        }
        else
        {
            agent.ResetPath();
        }
}
}
