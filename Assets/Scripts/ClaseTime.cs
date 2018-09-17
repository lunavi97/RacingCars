using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClaseTime : MonoBehaviour {

    public float dt, ts, rt;
	void Update () {
        dt += Time.deltaTime;
        Time.timeScale = ts;
        rt = Time.realtimeSinceStartup;
	}
}
