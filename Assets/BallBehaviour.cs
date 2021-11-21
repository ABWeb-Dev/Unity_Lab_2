using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    public float xOrbitRotation = 0;
    public float yOrbitRotation = 1;
    public float zOrbitRotation = 0;
    public float degreesPerSecond = 180;

    public float xObjectRotation = 0;
    public float yObjectRotation = 0;
    public float zObjectRotation = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 orbit = new Vector3(xOrbitRotation, yOrbitRotation, zOrbitRotation);
        transform.RotateAround(Vector3.zero, orbit, degreesPerSecond * Time.deltaTime);

        Vector3 rotatingObject = new Vector3(xObjectRotation, yObjectRotation, zObjectRotation);
        transform.Rotate(rotatingObject, degreesPerSecond * Time.deltaTime);
       


    }
}
