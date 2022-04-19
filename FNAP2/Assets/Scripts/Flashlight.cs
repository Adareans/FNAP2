using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Flashlight : MonoBehaviour
{

    public GameObject ON;
    public GameObject OFF;
    public AudioSource lightsound;
    private bool isON;
    // Start is called before the first frame update
    void Start()
    {
        ON.SetActive(false);
        OFF.SetActive(true);
        isON = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F)){
           
           if(isON){
                ON.SetActive(false);
                OFF.SetActive(true);
                
                lightsound.volume = (1.1f);

                lightsound.pitch = (.9f);

                lightsound.Play();
           }

            if(!isON){
                ON.SetActive(true);
                OFF.SetActive(false);
            
                lightsound.volume = (.5f);

                lightsound.pitch = (.7f);

                lightsound.Play();
            }

            isON = !isON;
        }
    }
}
