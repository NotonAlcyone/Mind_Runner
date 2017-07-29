using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundControl : MonoBehaviour {

    public float[] Speed;
    public GameObject[] BG;

    private Material[] render;


    private float[] offset;

    void Start () {

        render = new Material[BG.Length];
        offset = new float[Speed.Length];

        for (int i = 0; i < BG.Length; i++)
        {

            render[i] = BG[i].GetComponent<Renderer>().material;
        }

    }

    void Update () {
        for (int i = 0; i < BG.Length; i++)
        {
            offset[i] += Time.deltaTime * Speed[i];
            render[i].mainTextureOffset = new Vector2(offset[i], 0);
        }

    }
}
