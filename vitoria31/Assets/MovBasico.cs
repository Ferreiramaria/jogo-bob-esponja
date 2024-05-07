using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovBasico : MonoBehaviour
{
    private Rigidbody2D rB;
    public float speedP;
    public GameObject Bala;

    
    void Start()
    {
        rB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mov = new Vector2(Input.GetAxisRaw("Horizontal"), (Input.GetAxisRaw("Vertical")));
        rB.velocity = speedP * mov;

        SpawnTiro();
    }
    void SpawnTiro()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Instantiate(Bala, new Vector2(transform.position.x, transform.position.y + 1), Quaternion.identity);
        }
    }
}
