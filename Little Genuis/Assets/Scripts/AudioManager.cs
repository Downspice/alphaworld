﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {

	
	void Awake ()
    {
        DontDestroyOnLoad(this.gameObject);
	}
	

}
