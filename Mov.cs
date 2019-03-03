using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov : MonoBehaviour
{
    public Rigidbody rb;
    public float movSp;
    Vector2 movDir;
    

    void Start()
    {

        rb = GetComponent<Rigidbody>();

    }

    
    void Update()
    {
        //Teclado
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        movDir = (h * transform.right + v * transform.up);
        rb.velocity = movDir * movSp * Time.deltaTime;
        //TecladoFin

        //Mando
        float hc = Input.GetAxis("HorizontalC");
        float vc = Input.GetAxis("VerticalC");

        movDir = (hc * transform.right + vc * transform.up);
        rb.velocity = movDir * movSp * Time.deltaTime;
        //MandoFin
    }
}
