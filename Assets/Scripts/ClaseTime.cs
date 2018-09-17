using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClaseTime : MonoBehaviour {

    public float dt;
	void Update () {
        dt = Time.deltaTime;
	}
}
