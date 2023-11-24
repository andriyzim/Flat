using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class VrHelper : MonoBehaviour
{
    LaserPointer lp;
    LineRenderer lr;

    public LaserPointer.LaserBeamBehavior laserBeamBehavior;

    void Awake()
    {
        lp = FindObjectOfType<LaserPointer>();
        GetComponent<OVRRaycaster>().pointer = lp.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
