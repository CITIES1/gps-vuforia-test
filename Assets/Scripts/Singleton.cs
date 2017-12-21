using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class Singleton
{
	private static Singleton instance;
	public float latitudGps;
    public float longitudGps;

	private Singleton() {}

	public static Singleton GetInstance() {
		if (instance == null) {
			instance = new Singleton();
		}
		return instance;
	}

    public double DistanceTo(double lat, double lon, char unit = 'K')
    {
        double rlat1 = Math.PI * lat / 180;
        double rlat2 = Math.PI * latitudGps / 180;
        double theta = lon - longitudGps;
        double rtheta = Math.PI * theta / 180;
        double dist =
            Math.Sin(rlat1) * Math.Sin(rlat2) + Math.Cos(rlat1) *
            Math.Cos(rlat2) * Math.Cos(rtheta);
        dist = Math.Acos(dist);
        dist = dist * 180 / Math.PI;
        dist = dist * 60 * 1.1515;

        switch (unit)
        {
            case 'K': //Kilometers -> default
                return dist * 1.609344;
            case 'N': //Nautical Miles 
                return dist * 0.8684;
            case 'M': //Miles
                return dist;
        }

        return dist;
    }
}

