using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Hora : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI textHora;

    float hora;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textHora.text = System.DateTime.Now.ToString();

        //float minutes = Mathf.FloorToInt(hora / 60);
        //float second = Mathf.FloorToInt(hora % 60);

        //if (second < 10)
        //{
        //    textHora.text = minutes.ToString() + ": 0" + second.ToString();

        //}
        //else
        //{
        //    textHora.text = minutes.ToString() + ": " + second.ToString();
        //}
    }
}
