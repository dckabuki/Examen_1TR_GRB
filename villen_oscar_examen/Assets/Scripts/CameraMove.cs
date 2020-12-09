using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    //variable para captrar la nave
    [SerializeField] Transform Tarjet;

    //Variables necesarias para la opción de suavizado en el seguimiento
    [SerializeField] float smoothVelocity = 0.3F;
    private Vector3 camaraVelocity = Vector3.zero;
    private float alturaCamara = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Líneas para seguir al objetivo con suavidad
        Vector3 targetPosition = new Vector3(Tarjet.position.x, alturaCamara, transform.position.z);
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref camaraVelocity, smoothVelocity);
    }
}
