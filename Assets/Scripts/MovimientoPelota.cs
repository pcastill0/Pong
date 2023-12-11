using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPelota : MonoBehaviour
{

    private Vector3 direccion;
    public float speed;
    public Puntuacion punt;

    void Start()
    {
        Spawn();

        punt = FindObjectOfType<Puntuacion>();
    }

    void Update()
    {
        transform.position += direccion * Time.deltaTime * speed;
    }

    private void Spawn()
    {
        transform.position = Vector3.zero;
        float horizontal = Random.Range(-1f, 1f);
        if (horizontal > 0)
        {
            horizontal = 1;
        } else
        {
            horizontal = -1;
        }
        float vertical = Random.Range(-1f, 1f);
        direccion = new Vector3(horizontal, vertical, 0f).normalized;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.name);

        if (collision.gameObject.CompareTag("Horizontal"))
        {
            direccion.y *= -1;
        }

        if (collision.gameObject.CompareTag("Vertical"))
        {
            direccion.x *= -1;
        }

        if (collision.gameObject.CompareTag("Porteria1"))
        {
            Spawn();
            if (punt != null)
            {
                punt.jugador2++;
            }
        }

        if (collision.gameObject.CompareTag("Porteria2"))
        {
            Spawn();
            if (punt != null)
            {
                punt.jugador1++;
            }
        }
    }
}
