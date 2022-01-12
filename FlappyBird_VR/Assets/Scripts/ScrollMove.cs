using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollMove : MonoBehaviour
{
    public float scrollSpeed;
    float target0ffset;

    void Update()
    {
        target0ffset += Time.deltaTime * scrollSpeed;
        GetComponent<Renderer>().material.mainTextureOffset =
            new Vector2(target0ffset, -0.01f);
    }
}
