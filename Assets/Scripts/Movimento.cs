using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Movimento : MonoBehaviour
{
    Vector2 m;
    float velocidadepulo = 5.0f;
    Rigidbody2D movimento;
    public string Cena;
    double vida;
    public Text vidas;
    void Start()
    {
        m.x = 0.0f;
        m.y = 0.0f;
        movimento = GetComponent<Rigidbody2D>();
        vida = 2;

    }

    // Update is called once per frame
    void Update()
    {
        vidas.text = vida.ToString("0");
        if(vida <= 0){
            SceneManager.LoadScene(Cena);
        }
        if(Input.GetKey("d")){
            m.x = 0.01f;
            Movimentacao(m);
        }
                if(Input.GetKey("a")){
            m.x = -0.01f;
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
    void OnTriggerEnter2D(Collider2D tiro){
        if(tiro.gameObject.tag == "Projetil"){
        vida = vida - 1;
        }
        if(tiro.gameObject.tag == "Pendulo"){
            SceneManager.LoadScene(Cena);
        }
    }
}
