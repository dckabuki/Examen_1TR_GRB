using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextoTiempo : MonoBehaviour
{

    [SerializeField] Text TextTiempo;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Tiempo");
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator Tiempo()
    {
        //Bucle infinito que suma 1 en cada ciclo
        //El segundo parámetro está vacío, por eso es infinito
        for (int n = 0; ; n += 1)
        {
            //Cambio el texto que aparece en pantalla
            TextTiempo.text = "Tiempo: " + n + "segundos";


            //Ejecuto cada ciclo esperando un segundo

            yield return new WaitForSeconds(1f);
        }
    }
}
