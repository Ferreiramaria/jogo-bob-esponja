using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiroDoInimigo : MonoBehaviour
{
    Rigidbody2D rB;
    public float speedBalaI;
    public GameManager gM;

    // Start is called before the first frame update
    void Start()
    {
        rB = GetComponent<Rigidbody2D>();
        gM = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        rB.velocity = new Vector2(0, -speedBalaI);

        if (transform.position.y <= -5.47)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            gM.isGameOver = true;

        }
    }
}
