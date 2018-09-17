using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour {

    int numero = 10;
    float unDecimal = 10.5f;
    string texto = "Esto es un string";
    bool booleana = true;

	// Use this for initialization
	void Start () {
        Debug.Log(numero);
        Debug.Log(unDecimal);
        Debug.Log(texto);
        Debug.Log(booleana);
	}
}
