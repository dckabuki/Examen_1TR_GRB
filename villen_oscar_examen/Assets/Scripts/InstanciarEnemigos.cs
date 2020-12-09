using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class InstanciarEnemigos : MonoBehaviour
{

    //Variable que contendrá el prefab con el obstáculo
    [SerializeField] GameObject Bola;
    //Variable que tiene la posición del objeto de referencia
    [SerializeField] Transform InitPos;


    private float randomNumber1;
    private float randomNumber2;
    private float randomNumber3;

    Vector3 RandomPos;
    Vector3 InitCol;


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
        //creamos 20 bolas al lanzar el juego

        for (int i = 1; i < 20; i++)
        {
            //damos valor a la variable randomNumber. Le asignamos un rango aleatorio entre -20 y 20
            randomNumber1 = Random.Range(-40f, 40f);
            randomNumber2 = Random.Range(0f, 20f);
            randomNumber3 = Random.Range(-40f, 40f);

            //le asignamos las variables de posición aleatoria dentro de los límites 

            InitCol = new Vector3(randomNumber1, randomNumber2, randomNumber3);
            Vector3 newPosition = InitPos.position + InitCol;
            //con instantiate instanciamos las bolas. Le decimos qué instanciar, dónde y 
            //con quaternion le damos la rotación. Pasándole identity le decimos que no rota
            Instantiate(Bola, newPosition, Quaternion.identity);
        }

        StartCoroutine("InstanciadorBolas");

    }

    // Update is called once per frame
    void Update()
    {
        

    }

    //Función que crea una columna en una posición Random
    void CrearBola()
    {
        randomNumber1 = Random.Range(-40f, 40f);
        randomNumber2 = Random.Range(0f, 20f);
        randomNumber3 = Random.Range(-40f, 40f);

        //damos valores aleatorios a todos los ejes de las bolas
        RandomPos = new Vector3(randomNumber1, randomNumber2, randomNumber3);
        
        Vector3 FinalPos = InitPos.position + RandomPos;
        Instantiate(Bola, FinalPos, Quaternion.identity);
    }

    //corrutina para crear bolas nuevas

    IEnumerator InstanciadorBolas()
    {
        //bucle para que se creen las bolas
        for (; ; )
        {
            //para crear una bola, de momento cada 4 segundos
            CrearBola();
            //la variable interval sirve para dar frecuencia a la corrutina. Por ahora, 4 segundos. Debo asociarla al número de bolas existentes. 
            float interval = 4f;
            yield return new WaitForSeconds(interval);
        }


    }
}

