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

    public bool playercheck;
    float intervalotiro;
    void Start(){
        playercheck = false;
        intervalotiro = 1;
    }

    // Update is called once per frame
    void Update(){



        RaycastHit2D hit = Physics2D.Raycast(posicaoprojetil.position, Vector2.left, 10.0f, 1 << LayerMask.NameToLayer("Player"));
        if(hit.collider != null){
            playercheck = true;
            intervalotiro = intervalotiro + Time.deltaTime;
        }
        else
        {
            playercheck = false;
        }
        
        if(playercheck && intervalotiro >= 1){
            Atirar();
            intervalotiro = 0;
        }

    }
    void Atirar(){

        Rigidbody2D prefab = Instantiate(projetil, posicaoprojetil.transform.position, posicaoprojetil.transform.localRotation);
        prefab.velocity = -transform.right * (velocidadeprojetil/300);
    }
}
