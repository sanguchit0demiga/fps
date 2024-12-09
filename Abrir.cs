using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abrir : MonoBehaviour
{
    public Animator puerta;

    private void OnTriggerEnter(Collider other)
    {
        puerta.Play("abrir");
    }
}
