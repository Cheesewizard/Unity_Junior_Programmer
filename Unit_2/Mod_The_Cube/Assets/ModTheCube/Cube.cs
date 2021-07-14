using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;

    public float lerpSpeed = 0.1f;
    public float rotateX = 20.0f;
    public float rotateY = 10.0f;
    private Renderer rend;

    void Start()
    {
        transform.localScale = Vector3.one * 1.3f;
        rend = GetComponent<Renderer>();
    }

    void Update()
    {
        rend.material.SetColor("_Color", HSBColor.ToColor(new HSBColor(Mathf.PingPong(Time.time * lerpSpeed, 1), 1, 1)));
        transform.Rotate(rotateX * Time.deltaTime, 0.0f, rotateY * Time.deltaTime);
    }
}
