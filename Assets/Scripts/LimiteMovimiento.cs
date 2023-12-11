using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimiteMovimiento : MonoBehaviour
{
    public float limiteXpositivo;
    public float limiteXnegativo;

    public float limiteYpositivo;
    public float limiteYnegativo;

    void Update()
    {
        if (limiteYpositivo < transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, limiteYpositivo, 0);
        }

        if (limiteYnegativo > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, limiteYnegativo, 0);
        }

        if (limiteXpositivo < transform.position.x)
        {
            transform.position = new Vector3(limiteXpositivo, transform.position.y, 0);
        }

        if (limiteXnegativo > transform.position.x)
        {
            transform.position = new Vector3(limiteXnegativo, transform.position.y, 0);
        }
    }
}
