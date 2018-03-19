﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pacer : MonoBehaviour {

    public float speed = 5.0f;
    public float zMax = 7.5f;
    public float zMin = -7.5f;
    public int direction = 1;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float zNew = transform.position.z + direction * speed * Time.deltaTime;


        if (zNew >= zMax) {
            zNew = zMax;
            direction *= -1;

        } else if (zNew<=zMin) {
            zNew = zMin;
            direction *= -1;
        }

        transform.position = new Vector3(7.5f, 1.75f, zNew);
	}
}
