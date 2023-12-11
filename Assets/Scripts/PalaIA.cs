using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PalaIA : MonoBehaviour
{
    public GameObject pelota;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float vertical = 0;
        if(transform.position.y > pelota.transform.position.y)
        {
            vertical = -1;
        }

        if (transform.position.y < pelota.transform.position.y)
        {
            vertical = 1;
           
        } 
        transform.position += new Vector3(0, vertical, 0) * Time.deltaTime * speed;
    }
}
