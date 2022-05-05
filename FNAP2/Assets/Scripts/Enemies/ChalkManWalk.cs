using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ChalkManWalk : MonoBehaviour
{
    public Transform home1;
    public Transform home2; 
    private bool goingToHome1 = false; 
    

    // Start is called before the first frame update
    void Start()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = home1.position;
        goingToHome1 = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (agent.position == home1.position && goingToHome1 == true)
        {
            agent.destination = home2.position;
            goingToHome1 = false;
        }
        if (agent.position == home2.position && goingToHome1 == false)
        {
            agent.destination = home2.position;
            goingToHome1 = true;
        }
    }
}
