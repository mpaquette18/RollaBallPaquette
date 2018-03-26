using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBall : MonoBehaviour {
    SteamVR_TrackedObject trackedObj;
    SteamVR_Controller.Device device;

    public float rollX;
    public float rollY;
    // Use this for initialization
    void Awake () {
        trackedObj = GetComponent<SteamVR_TrackedObject>();
    }
	
	// Update is called once per frame
	void Update () {
        device = SteamVR_Controller.Input((int)trackedObj.index);
         rollX = device.GetAxis(Valve.VR.EVRButtonId.k_EButton_Axis0).x;
         rollY = device.GetAxis(Valve.VR.EVRButtonId.k_EButton_Axis0).y;
      
        

    }




 

}
