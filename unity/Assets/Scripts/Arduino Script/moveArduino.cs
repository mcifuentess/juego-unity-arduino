using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System.IO.Ports;

public class moveArduino : MonoBehaviour
{
    SerialPort puerto = new SerialPort("COM5", 9600);

    private Rigidbody rb;

    private float movementForce = 0.1f, jumpForce = 0.8f;
    private float jumpTime = 0.15f;

    public float distanciaMov = 0.2f;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Start is called before the first frame update
    void Start()
    {
        puerto.Open();
        puerto.ReadTimeout = 1; 
    }

    // Update is called once per frame
    void Update()
    {
        if (puerto.IsOpen)
        {
            try
            {
                mover(puerto.ReadByte());
            }
                catch (System.Exception)
            {

            }
        }
    }

    void mover (int direccion)
    {
        if (direccion == 1)
        {
            transform.DORotate(new Vector3(0f, 90f, 0f), 0f);

            rb.DOJump(new Vector3(
                transform.position.x - movementForce, transform.position.y + jumpForce,
                transform.position.z), 0.5f, 1, jumpTime);
        }

        //Space.World: se mueve en las coordenadas del espacio local donde esta el GameObject
        //Space.Self: se utiliza para rotación sobre si mismo, con los ejes que el objeto tenga
        //Camera.main.transform: se mueve relativo a las coordenadas de la camara

        if (direccion == 2)
        {
            transform.DORotate(new Vector3(0f, -180f, 0f), 0f);

            rb.DOJump(new Vector3(
                transform.position.x, transform.position.y + jumpForce,
                transform.position.z + movementForce), 0.5f, 1, jumpTime);
        }
    }
}
