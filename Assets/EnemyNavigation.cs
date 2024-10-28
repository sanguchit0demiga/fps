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
    public float initialDelay;
    public float interval;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        player= GameObject.FindGameObjectWithTag("Player").transform;
        
        InvokeRepeating("SetDestination", initialDelay, interval);
        
    }

  
    
    public void SetDestination()
    {
        agent.destination = player.position;
    }
}
