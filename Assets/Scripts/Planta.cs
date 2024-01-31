using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planta : MonoBehaviour
{
    public Animator animator;
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == ("Accionar"))
        {
            animator.enabled = true;
            Debug.Log("entro");
        }
    }
}
