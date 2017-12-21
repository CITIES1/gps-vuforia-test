using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class ObjGeo : MonoBehaviour {

    public float lat, lon;    

    // Use this for initialization
    void Start () {
        this.gameObject.GetComponent<Renderer>().material.color = Color.green;
        
    }
	
	// Update is called once per frame
	void Update () {

        /*
        double distanceK = DistanceTo(this.lat, this.lon, Singleton.GetInstance().latitudGps, Singleton.GetInstance().longitudGps);
        distanceText.text = distanceK.ToString();
        coordsText.text = "lat: " + Singleton.GetInstance().latitudGps.ToString() + " long: " + Singleton.GetInstance().longitudGps.ToString();

        if(distanceK < 2.0)
        {
            this.gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
        else
        {
            this.gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
        */
	}



}
