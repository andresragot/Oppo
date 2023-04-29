using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    Transform linea1, linea2, linea3;

    [SerializeField]
    GameObject pinchoPrefab;

    [SerializeField]
    float tiempoPinchos;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("HacerPincho", 0, tiempoPinchos);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void  HacerPincho()
    {
        float value = Random.value;

        if(value <= 0.16)
        {
            GameObject go = Instantiate(pinchoPrefab);
            go.transform.position = new Vector3(linea1.position.x, transform.position.y, 0);
        }
        else if (value <= 0.32)
        {
            GameObject go = Instantiate(pinchoPrefab);
            go.transform.position = new Vector3(linea2.position.x, transform.position.y, 0);
        }
        else if (value <= 0.48)
        {
            GameObject go = Instantiate(pinchoPrefab);
            go.transform.position = new Vector3(linea3.position.x, transform.position.y, 0);
        }
        else if (value <= 0.64)
        {
            GameObject go = Instantiate(pinchoPrefab);
            go.transform.position = new Vector3(linea1.position.x, transform.position.y, 0);
            go = Instantiate(pinchoPrefab);
            go.transform.position = new Vector3(linea2.position.x, transform.position.y, 0);
        }
        else if (value <= 0.80)
        {
            GameObject go = Instantiate(pinchoPrefab);
            go.transform.position = new Vector3(linea1.position.x, transform.position.y, 0);
            go = Instantiate(pinchoPrefab);
            go.transform.position = new Vector3(linea3.position.x, transform.position.y, 0);
        }
        else
        {
            GameObject go = Instantiate(pinchoPrefab);
            go.transform.position = new Vector3(linea3.position.x, transform.position.y, 0);
            go = Instantiate(pinchoPrefab);
            go.transform.position = new Vector3(linea2.position.x, transform.position.y, 0);
        }

    }

}
