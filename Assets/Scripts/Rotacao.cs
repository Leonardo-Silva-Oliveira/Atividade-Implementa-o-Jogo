using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacao : MonoBehaviour
{
    Vector3 a;
    float x, y, z;
    // Start is called before the first frame update
    void Start()
    {
        a.x = 0.3f;
        a.y = 0.3f;
        a.z = 0.3f;
    }

    // Update is called once per frame
    void Update()
    {
            Rotaçao(a);
    }
    void Rotaçao(Vector3 a)
    {
        transform.Rotate(a);
    }
}
