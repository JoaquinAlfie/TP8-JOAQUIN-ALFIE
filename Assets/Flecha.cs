using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flecha : MonoBehaviour
{
    public GameObject[] Lista;
    public int numIndice;

    void Start()
    {
        for (int indice = 1; indice < Lista.Length; indice++)
        {
            Lista[indice].SetActive(false);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            numIndice++;
            if (numIndice >= 18)
            {
                numIndice = 17;
            }
            Lista[numIndice - 1].SetActive(false);
            Lista[numIndice].SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            numIndice--;
            if (0 > numIndice)
            {
                numIndice = 0;
            }
            Lista[numIndice + 1].SetActive(false);
            Lista[numIndice].SetActive(true);
        }
    }
}
