using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour
{
    Rigidbody2D rB;
    public float speedI;
    public GameObject BalaI;
    public int contador;
    private float verificarCow;
    public float TempodoCow;
    public GameObject inimigo;
    

    
    void Start()
    {
        rB = GetComponent<Rigidbody2D>();
       
    }

    // Update is called once per frame
    void Update()
    {
        

        rB.velocity = new Vector2(0, -speedI);

        if(transform.position.y <= -6)
        {
            Destroy(gameObject);
        }

        if(Time.time >= verificarCow)
        {
            verificarCow = Time.time + TempodoCow;
            SpawnTiroInimigo();
            
        }
        

    }
    void SpawnTiroInimigo()
    {
        Vector2 posicao = new Vector2(transform.position.x, transform.position.y - 1);
        Instantiate(BalaI, posicao, Quaternion.identity);
    }
}
