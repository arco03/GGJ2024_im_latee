using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sonidos : MonoBehaviour
{
    public AudioSource sonidoMoneda;
    private float sound = 1f;
    Vida vida;

    public string sonidos;
    void Start()
    {
        vida = FindObjectOfType<Vida>();
        sonidoMoneda = GetComponent<AudioSource>();
    }

    // Update is called once per frame
   
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        switch (sonidos)
        {
            case "Trash":
                if (other.gameObject.CompareTag("Player"))
                {
                    vida.Sound();
                    Invoke("Sound", sound);
                    sonido();

                }

                break;
            case "Barricada":
                if (other.gameObject.CompareTag("Player"))
                {

                    vida.Sound();
                    Invoke("Sound", sound);
                    sonido();
                }

                break;
            case "Matera":
                if (other.gameObject.CompareTag("Player"))
                {

                    vida.Sound();
                    Invoke("Sound", sound);
                    sonido();
                }

                break;
            case "Bed":
                if (other.gameObject.CompareTag("Player"))
                {

                    vida.Sound();
                    Invoke("Sound", sound);
                    sonido();
                }

                break;
            case "Chair":
                if (other.gameObject.CompareTag("Player"))
                {

                    vida.Sound();
                    Invoke("Sound", sound);
                    sonido();
                }

                break;
            case "Hydrant":
                if (other.gameObject.CompareTag("Player"))
                {

                    vida.Sound();
                    Invoke("Sound", sound);
                    sonido();
                }

                break;
            case "Cono":
                if (other.gameObject.CompareTag("Player"))
                {

                    vida.Sound();
                    Invoke("Sound", sound);
                    sonido();
                }

                break;


        }
    }
    public void sonido()
    {
        sonidoMoneda.Play();
    }
}
