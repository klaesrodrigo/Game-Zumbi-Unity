using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaInimigo : MonoBehaviour {

    public GameObject Jogador;
    public float Velocidade;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void FixedUpdate()
    {
        Vector3 direcao = Jogador.transform.position - transform.position;
        GetComponent<Rigidbody>().MovePosition 
            (GetComponent<Rigidbody>().position + 
            direcao.normalized * Velocidade * Time.deltaTime);
    }
}
