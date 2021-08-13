using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractableScript : MonoBehaviour
{
    private List<Vector3> originalPinVecs = new List<Vector3>();

    private List<Vector3> originalBallVecs = new List<Vector3>();


    private bool boundsControl;

    private List<GameObject> Pins = new List<GameObject>();

    private List<GameObject> Balls = new List<GameObject>();

    


    // Start is called before the first frame update
    void Start()
    {
        // Get originals for balls
        for (int i = 1; i < 5; i++)
        {
            string name = "Sphere " + i;
            GameObject Ball = GameObject.Find(name);
            originalBallVecs.Add(new Vector3(Ball.transform.position.x, Ball.transform.position.y, Ball.transform.position.z));
            Balls.Add(Ball);
        }

        // Get originals for pins
        for (int i = 1; i < 7; i++)
        {
            string name = "Cylinder " + i;
            GameObject Pin = GameObject.Find(name);
            originalPinVecs.Add(new Vector3(Pin.transform.position.x, Pin.transform.position.y, Pin.transform.position.z));
            Pins.Add(Pin);
        }

        boundsControl = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void resetBalls()
    {
        for (int i = 0; i < 4; i++)
        {
            Balls[i].transform.position = originalBallVecs[i];
            Balls[i].transform.rotation = Quaternion.identity;
        }
    }

    public void resetPins()
    {
        for (int i = 0; i < 6; i++)
        {
            Pins[i].transform.position = originalPinVecs[i];
            Pins[i].transform.rotation = Quaternion.identity;
        }
    }

    public void setBoundsControl()
    {
        boundsControl = !boundsControl;
    }

    public void addBalls()
    {
        Debug.Log("addBalls clicked");
    }
}
