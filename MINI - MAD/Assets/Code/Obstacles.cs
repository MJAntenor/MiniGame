using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private Vector3 dir = Vector3.left;

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(dir * speed * Time.deltaTime);
    }
}
