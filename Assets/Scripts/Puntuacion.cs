using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Puntuacion : MonoBehaviour
{
    public int jugador1;
    public TMP_Text jugador1Texto;
    public GameObject jugador1Ganador;

    public int jugador2;
    public TMP_Text jugador2Texto;
    public GameObject jugador2Ganador;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        jugador1Texto.text = jugador1.ToString();
        jugador2Texto.text = jugador2.ToString();

        if(jugador1 >= 10){
            jugador1Ganador.SetActive(true);
            Time.timeScale = 0;
        }

        if (jugador2 >= 10)
        {
            jugador2Ganador.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
