using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        rB = GetComponent<Rigidbody2D>();
        rB.velocity = new Vector2(0, -speedI3);
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
