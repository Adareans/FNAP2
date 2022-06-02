using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class menu : MonoBehaviour
{
    public bool isflickering = false; 
    public float timeDelay; 
 
    void Update()
    {
        if (isflickering == false)
        {
            StartCoroutine(FlickeringLight());
        }    
    }
 
    IEnumerator FlickeringLight()
    {
        isflickering = true;
        this.gameObject.GetComponent<Light>().enabled = false;
        timeDelay = Random.Range(0.2f, 0.5f);
        yield return new WaitForSeconds(timeDelay);
        this.gameObject.GetComponent<Light>().enabled = true;
        timeDelay = Random.Range(0.2f, 0.5f);
        yield return new WaitForSeconds(timeDelay);
        isflickering = false;
    }
}
 

