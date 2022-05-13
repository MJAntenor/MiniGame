using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private Vector3 dir = Vector3.left;

    public float maxX;
    public float maxY;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 theScale = transform.localScale;
        float randX = Random.Range((float)0.5, maxX);
        float randY = Random.Range((float).5, maxY);
        theScale.x = randX;
        theScale.y = randY;
        transform.localScale = theScale;
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(dir * speed * Time.deltaTime);
    }
}
