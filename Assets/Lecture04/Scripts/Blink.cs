using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blink : MonoBehaviour
{
    [SerializeField] float speed = 0.35f;

    MeshRenderer meshRenderer;

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            meshRenderer.material.color = Random.ColorHSV();
        }

        float h = Input.GetAxis("Horizontal");

        transform.localPosition += new Vector3(h, 0, 0) * speed * Time.deltaTime;
    }
}
