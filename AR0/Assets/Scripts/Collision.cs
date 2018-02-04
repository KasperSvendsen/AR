using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour {

    public GameObject meteor; //Public so it can be reached outside script

    //private Vector3 positionOffset;
    private double dist;
    private double radius; 



    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //positionOffset = transform.position - meteor.transform.position; //Position offset between earth and meteor
        float dist = Vector3.Distance(meteor.transform.position, transform.position);
        radius = transform.localScale.x + meteor.transform.localScale.x; //scale offset

        print("dist" + dist);
        //print("radius" + radius); ==1.21


        if(dist <= radius)// scaleOffset.magnitude)
        {
            print("Collision!");
        };

    }
}
