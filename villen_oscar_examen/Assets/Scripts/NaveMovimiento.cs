using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveMovimiento : MonoBehaviour
{

    private float moveSpeed = 3f;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoverNave();
    }
    //método para mover la nave
    void MoverNave ()
    {
        //movimiento horizontal
        float desplX = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * moveSpeed * desplX);

        //movimiento frontal. Con el eje vertical y el vector3 indicando hacia adelante, debería moverse de frente 
        float desplZ = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed * desplZ);

        //subir y bajar
        float desplY = Input.GetAxis("UpDown");
        transform.Translate(Vector3.up * Time.deltaTime * moveSpeed * desplY); 

    }

}
