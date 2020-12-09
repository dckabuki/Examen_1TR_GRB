using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaCollider : MonoBehaviour
{
    //codigo para la colision, que al chocar con el objeto con etiqueta Player se destruya la bola

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
