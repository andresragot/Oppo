using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pincho : MonoBehaviour
{
    [SerializeField]
    float tiempoPincho;

    // Update is called once per frame
    void Update()
    {
        if (tiempoPincho <= 0)
        {
            Destroy(gameObject);
        }
        else
        {
            tiempoPincho -= Time.deltaTime;
        }
    }
}
