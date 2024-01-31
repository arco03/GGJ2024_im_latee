using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Vida : MonoBehaviour
{
    public Image[] imagen;
   
    public GameObject GameOver;
    
    public AudioSource sonidoMoneda;
    public Movimiento move;


    public GameObject Frase;
    int conta = 0;
    

    private void Start()
    {
 
        Invoke("activar", 1.5f);
        Invoke("desactivar", 3.2f);
     


    }

    private void OnCollisionEnter2D(Collision2D other)
    {
   
                if (other.gameObject.CompareTag("Bloque"))
                {
                    contador();
                 
                    
                }

           
    }
    public void gameOver()
    {
        Time.timeScale = 0f;
        GameOver.SetActive(true);
        
    }
    public void Reiniciar()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
    public void contador()
    {

        imagen[conta].fillAmount = 0;
        conta++;
        if (conta == 3)
        {
            gameOver();

        }
    }
    public void Sound()
    {
      sonidoMoneda.Play();
    }
    private void desactivar()
    {
        Frase.gameObject.SetActive(false);
        move.enabled = true;
    }
    private void activar ()
    {
        Frase.gameObject.SetActive(true);
        move.enabled = false;
    }
}
