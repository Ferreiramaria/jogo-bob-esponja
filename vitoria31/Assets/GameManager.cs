using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float intervalo;
    public float intervalo2;
    public float intervalo3;
    public GameObject Inimigo;
    public GameObject Inimigo2;
    public GameObject Inimigo3;
    public float delay = 2;
    public float delay2 = 2;
    public float delay3 = 2;
    public bool isGameOver;

    public AudioSource audioPlayer;
    public AudioClip deathAudio;
    public AudioClip powerUpSound;
    


    public int pontuacao;
    public TextMeshProUGUI ponto;

    void Start()
    {
        intervalo2 = Time.time + delay2;
        intervalo = Time.time + delay;
        intervalo3 = Time.time + delay3;

        pontuacao = 0;
        ponto.text = "0";

        audioPlayer = GetComponent<AudioSource>();

    }

    
    void Update()
    {

        if (isGameOver == false)
        {
            SpawnInimigo1();
            SpawnInimigo2();
            SpawnInimigo3();

            ponto.text = pontuacao.ToString();
        }
        
    }
   void SpawnInimigo1()
    {
        if(intervalo <= Time.time)
        {
            Instantiate(Inimigo, new Vector2(Random.Range(-2.2f, 2.2f),Random.Range(5.6f, 9)),Quaternion.identity);
            intervalo = Time.time + delay;
        }
    }
    void SpawnInimigo2()
    {
        if (intervalo2 <= Time.time)
        {
            Instantiate(Inimigo2, new Vector2(Random.Range(-2.2f, 2.2f), Random.Range(5.6f, 9)), Quaternion.identity);
            intervalo2 = Time.time + delay2;
        }
    }
    void SpawnInimigo3()
    {
        if (intervalo2 <= Time.time)
        {
            Instantiate(Inimigo3, new Vector2(Random.Range(-2.2f, 2.2f), Random.Range(5.6f, 9)), Quaternion.identity);
            intervalo3 = Time.time + delay3;
        }


    }

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PowerUpSpedd")
        {
            audioPlayer.PlayOneShot(powerUpSound);
            Destroy(collision.gameObject);
        }
    }
    public void Comecar()
    {
        SceneManager.LoadScene(1);
    }

    public void Sair()
    {
        Application.Quit();
    }

}
