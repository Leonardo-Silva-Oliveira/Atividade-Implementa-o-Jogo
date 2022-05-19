using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento : MonoBehaviour
{
    Vector2 m;
    float velocidadepulo = 5.0f;
    Rigidbody2D movimento;
    void Start()
    {
        m.x = 0.0f;
        m.y = 0.0f;
        movimento = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("d")){
            m.x = 0.03f;
            Movimentacao(m);
        }
                if(Input.GetKey("a")){
            m.x = -0.03f;
            Movimentacao(m);
        }
        if(Input.GetKey("space")){
                Pulo();
        }
    }
    void Movimentacao(Vector2 m){
        transform.Translate(m);
    }
    void Pulo(){
        movimento.velocity = new Vector2(movimento.velocity.x, velocidadepulo);
    }
}
