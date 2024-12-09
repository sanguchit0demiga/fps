using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aabrir : MonoBehaviour
{
    public Animator Door;


    private void OnTriggerEnter(Collider other)
    {
        Door.Play("aabrir");
    }


}
