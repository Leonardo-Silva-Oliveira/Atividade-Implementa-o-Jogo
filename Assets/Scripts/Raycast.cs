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

    // Update is called once per frame
    void Update(){
        if(Input.GetKeyDown("q")){
            Atirar();
        }
    }
    void Atirar(){
        Rigidbody2D prefab = Instantiate(projetil, posicaoprojetil.transform.position, posicaoprojetil.transform.localRotation);
        prefab.velocity = -transform.right * (velocidadeprojetil * Time.deltaTime);
    }

}
