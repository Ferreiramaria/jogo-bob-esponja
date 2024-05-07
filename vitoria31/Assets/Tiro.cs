using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiro : MonoBehaviour
{
    Rigidbody2D rB;
    public float speedBala;
    GameManager gM;
    
    void Start()
    {
        rB = GetComponent<Rigidbody2D>();
        gM = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        rB.velocity = new Vector2(0,speedBala * 1);

        if (transform.position.y >= 5.13)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "inimigo")
        {
            gM.pontuacao++;
            Destroy(gameObject);
            Destroy(collision.gameObject);

        }
    }
}
