using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Changing_Size_Script : MonoBehaviour
{
    public GameObject small;
    public GameObject medium;
    public GameObject large;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Small")
        {
            small.SetActive(true);
            medium.SetActive(false);
            large.SetActive(false);
        }

        if (other.gameObject.tag == "Medium")
        {
            small.SetActive(false);
            medium.SetActive(true);
            large.SetActive(false);
        }

        if (other.gameObject.tag == "large")
        {
            small.SetActive(false);
            medium.SetActive(false);
            large.SetActive(true);
        }
    }
}
