using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    Transform linea1, linea2, linea3;

    [SerializeField]
    GameObject pinchoPrefab;

    [SerializeField]
    float tiempoPinchos;

    [SerializeField]
    Sprite[] imageBoton;

    [SerializeField]
    Image imageHandler;

    bool imagen = false;

    [SerializeField]
    float timePoint, points;

    float initialTime;

    [SerializeField]
    TextMeshProUGUI textScore;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        initialTime = Time.time;
        StartCoroutine(HacerPincho());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            CambiarBoton();
        }
    }

    IEnumerator  HacerPincho()
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

        yield return new  WaitForSeconds(tiempoPinchos);
        
        if(tiempoPinchos>0.4)
            tiempoPinchos -= 0.1f;
        else
        {
            tiempoPinchos = 0.3f;
        }

        StartCoroutine(HacerPincho());

    }

    public void CambiarBoton()
    {
        
        if (imagen)
        {
            imageHandler.sprite = imageBoton[0];
            imagen = false;
        }
        else
        {
            imageHandler.sprite = imageBoton[1];
            imagen = true;
        }
    }

    public void Score()
    {
        float timeActual = Time.time;

        float hora = timeActual - initialTime;

        float minutes = Mathf.FloorToInt(hora / 60);
        float second = Mathf.FloorToInt(hora % 60);


        float score = minutes * points * 60 + second * points;

        textScore.text += score.ToString();
    }

    public void Retry()
    {
        Debug.Log("Se hace");
        SceneManager.LoadScene(0);
    }
}
