using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ChalkManWalk : MonoBehaviour
{
    public Transform home1;
    public Transform home2; 
    private bool goingToHome1 = false; 
    NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.destination = home1.position;
        goingToHome1 = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (agent.remainingDistance==0 && goingToHome1 == true)
        {
            agent.destination = home2.position;
            goingToHome1 = false;
        } else if (agent.remainingDistance==0 && goingToHome1 == false)
        {
            agent.destination = home1.position;
            goingToHome1 = true;
        }
    }
}
