﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplitscreenScript : MonoBehaviour {
    static int numCameras;
    public Camera cam1;
    public Camera cam2;
    public Camera cam3;
    public Camera cam4;

	// Use this for initialization
	void Start () {
		if (numCameras >= 3)
        {
            cam1.rect = new Rect(0, .51f, .5f, .49f);
            cam2.rect = new Rect(.505f,.51f,.5f,.49f);
            cam3.rect = new Rect(0,0,.5f,.49f);
            if (numCameras == 4)
            {
                cam4.rect = new Rect(.505f, 0, .5f, .49f);
            } else {
                // set cam4 to minimap???
            }
        }
	}
}