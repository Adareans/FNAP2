using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ChalkManWalk : MonoBehaviour
{
    public Transform home1;
    public Transform home2; 
    public Transform home3;
    public Transform home4;

    public GameObject player;
    public Transform spawn;

    private bool goingToHome1 = false; 
    private bool goingToHome2 = false;
    private bool goingToHome3 = false;
    private bool goingToHome4 = false; 

    Vector3 destination;
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
            destination = home2.position;
            goingToHome1 = false; 
            goingToHome2 = true;
            goingToHome3 = false; 
            goingToHome4 = false;
            StartCoroutine(setDestination(2));
        } else if (agent.remainingDistance==0 && goingToHome2 == true)
        {
            destination = home3.position;
            goingToHome1 = false;
            goingToHome2 = false;
            goingToHome3 = true;
            goingToHome4 = false;
            StartCoroutine(setDestination(3));
        
        } else if (agent.remainingDistance==0 && goingToHome3 == true)
        {
            destination = home4.position;
            goingToHome1 = false;
            goingToHome2 = false;
            goingToHome3 = false;
            goingToHome4 = true;
            StartCoroutine(setDestination(4));
        } else if (agent.remainingDistance==0 && goingToHome4 == true)
        {
            destination = home1.position;
            goingToHome4 = false;
            goingToHome1 = true; 
            goingToHome2 = false;
            goingToHome3 = false;
            StartCoroutine(setDestination(1));
        } 
    }

    IEnumerator setDestination(int dest) {
        yield return new WaitForSeconds(10f);

        agent.destination = destination;
        goingToHome1 = false;
        goingToHome2 = false;
        goingToHome3 = false;
        goingToHome4 = false;

        switch (dest) {
            case 1:
                goingToHome1 = true;
                break;
            case 2:
                goingToHome2 = true;
                break;
            case 3:
                goingToHome3 = true;
                break;
            case 4:
                goingToHome4 = true;
                break;
        }
    }
    void OnTriggerEnter(Collider other)
    {
     if (other.tag == "Door")
        {
            player.transform.position = home1.transform.position;
            Debug.Log(transform.position);
            
        }
    }
}
    

