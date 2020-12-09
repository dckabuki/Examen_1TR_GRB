using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

    [SerializeField] Text TextBolas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Bolas()
    {
        //Bucle infinito que suma 1 en cada ciclo
        //El segundo parámetro está vacío, por eso es infinito
        for (int n = 0; ; n += 1)
        {
            //Cambio el texto que aparece en pantalla
            TextBolas.text = "Bolas: ";


            //Ejecuto cada ciclo esperando un cuarto de segundo.
            //es el tiempo que va a tardar en ejecutarse
            //si le pasaramos un null a yield return se ejecutaría cada frame
            yield return new WaitForSeconds(0.25f);
        }
    }
}
