using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour {

    public GameObject meteor; //Public so it can be reached outside script
    public ParticleSystem explosion;

    private double dist;
    private double radius; 



    // Use this for initialization
    void Start()
    {
        explosion.Pause();
    }

    // Update is called once per frame
    void Update()
    {

        float dist = Vector3.Distance(meteor.transform.position, transform.position);
        radius = transform.localScale.x + meteor.transform.localScale.x; //scale offset

        //print("dist" + dist);
        //print("radius" + radius); ==1.21


        if(dist <= 3.7)//radius)
        {
            print("Collision!");
            explosion.Play();
        };

    }
}
