using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectControl : MonoBehaviour
{

    void Start()
    {
        Invoke("Destroyer", 0.2f);


    }

    void Destroyer()
    {
        Destroy(gameObject);
    }
    void Update()
    {

    }
}
