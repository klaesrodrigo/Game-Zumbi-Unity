﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaCamera : MonoBehaviour {

    public GameObject Jogador;
    Vector3 diffAlturaCameraJogador;

	// Use this for initialization
	void Start () {
        diffAlturaCameraJogador = transform.position - Jogador.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Jogador.transform.position + diffAlturaCameraJogador;
	}
}
