﻿using System.Collections;
using System.Collections.Generic;
using XInputDotNetPure;
using UnityEngine;

public class letest : MonoBehaviour {
	
    public x360_Gamepad gamepad;
    private GamepadManager manager;

	public int playerIndex;

	void Start () {
        manager = GamepadManager.Instance;
        gamepad=manager.GetGamepad(playerIndex);

        
    }

    void Update()
	{



		if (gamepad.GetButtonDown ("B")) {
			Debug.Log ("oui");
		}

		if (gamepad.GetButtonDown ("A")) {
			print ("A");
		}

		//print (gamepad.GetStick_L ().X);



        
	}
   
    }

