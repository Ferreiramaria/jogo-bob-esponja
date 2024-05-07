using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Morte : MonoBehaviour
{
   
    public GameManager gM;
    public string Tag;

    
    void Start()
    {
        gM = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == Tag)
        {
           
            Destroy(gameObject);
            Destroy(collision.gameObject);
            gM.isGameOver = true;
           
        }
    }
}
