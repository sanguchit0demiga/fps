using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open2 : MonoBehaviour
{

    public Animator Door;


    private void OnTriggerEnter(Collider other)
    {
        Door.Play("abrir2");
    }


}