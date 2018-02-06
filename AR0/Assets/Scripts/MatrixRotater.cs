using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatrixRotater : MonoBehaviour {

    public GameObject sun;
    private Vector3 dist;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Matrix4x4 modelTransform = transform.localToWorldMatrix;
        //Vector3 forward = modelTransform.GetColumn(2);

        dist = transform.position - sun.transform.position;

        Quaternion rotation = Quaternion.Euler(2,0,2);

        //transformation matrix
        //Matrix4x4 modelTransform = transform.localToWorldMatrix;
        //transform.position = modelTransform.GetColumn(2);
          
        Matrix4x4 rotationMatrix = Matrix4x4.Rotate(rotation); 

        //rotate earth
        transform.position = rotationMatrix.MultiplyVector(dist);
        //print(transform.position);



    }
}
