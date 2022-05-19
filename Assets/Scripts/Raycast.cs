using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D projetil;
    [SerializeField]
    float velocidadeprojetil;
    [SerializeField]
    Transform posicaoprojetil;
    [SerializeField]
    Transform castPoint;
    void Start(){
    }

    // Update is called once per frame
    void Update(){


        RaycastHit2D hit = Physics2D.Raycast(castPoint.position, Vector2.left);
        if(hit.collider != null){
            Debug.Log("Acertou");
        }

    }
    void Atirar(){
        Rigidbody2D prefab = Instantiate(projetil, posicaoprojetil.transform.position, posicaoprojetil.transform.localRotation);
        prefab.velocity = -transform.right * (velocidadeprojetil * Time.deltaTime * 2);
    }
}
