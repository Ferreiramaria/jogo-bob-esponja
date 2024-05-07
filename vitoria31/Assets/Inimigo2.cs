using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo2 : MonoBehaviour
{
    
    Rigidbody2D rB;
    
    void Start()
    {
        rB = GetComponent<Rigidbody2D>();
        rB.velocity = new Vector2(0, Random.Range(1,12)) * -1;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= -6)
        {
            Destroy(gameObject);
        }
    }
}
