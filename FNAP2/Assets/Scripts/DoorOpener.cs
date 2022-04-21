using System.Collections;
using UnityEngine;

public class DoorOpener : MonoBehaviour
{
    public GameObject Door;
    public bool up;
    public bool down;
    public bool upstop;
    public bool downstop;

    // Start is called before the first frame update
    void Start()
    {
        up = true;
        upstop = true;
    }

    // Update is called once per frame
    void Update() {
        if (up == true && down == false && upstop == false) {
            Door.transform.Translate(Vector3.up * Time.deltaTime * 15);
        }
        if (down == true && up == false && downstop == false) {
            Door.transform.Translate(Vector3.down * Time.deltaTime * 15);
        }

        if(Input.GetKeyDown(KeyCode.E)) {
            if (up && upstop) {
                down = true;
                up = false;
                upstop = false;
            } else if (down && downstop) {
                up = true;
                down = false;
                downstop = false;
            }
        }
        if (Door.transform.position.y > 10.5f)
        {
            upstop = true;
            downstop = false;
        }
        if (Door.transform.position.y < 3f) {
            downstop = true;
            upstop = false;
        }

    }


}