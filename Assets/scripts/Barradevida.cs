using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Barradevida : MonoBehaviour
{
    public Image barraDeVida;

    public float vidaActual;
    public float vidaMax;
    // Start is called before the first frame update
    void Start()
    {
        ActualizarBarra();
    }

    // Update is called once per frame
   public void ActualizarBarra()
    {
        barraDeVida.fillAmount = vidaActual/vidaMax;
    }
}
