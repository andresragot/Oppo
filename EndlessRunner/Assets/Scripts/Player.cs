using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField]
    Transform line1, line2, line3;

    [SerializeField]
    GameObject gameOver;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CambiarLinea(float lineaNum)
    {
        if (lineaNum <= 0.3)
        {
            transform.position = new Vector3(line1.position.x, transform.position.y, transform.position.z);
        }
        else if (lineaNum <= 0.65)
        {
            transform.position = new Vector3(line2.position.x, transform.position.y, transform.position.z);
        }
        else
        {
            transform.position = new Vector3(line3.position.x, transform.position.y, transform.position.z);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Pincho")
        {
            Time.timeScale = 0;
            gameOver.SetActive(true);
        }
    }
}
