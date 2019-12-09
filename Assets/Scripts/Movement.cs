using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private float speed = 20f;
    Vector3 startPos;
    Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {
        direction = Vector3.right;
        startPos = new Vector3(Random.Range(10, 20), 20, Random.Range(10, 20));
        this.transform.position = startPos;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
        if (this.transform.position.y > 90)
        {
            //Reset the position
            startPos = new Vector3(Random.Range(10, 20), 20, Random.Range(10, 20));
            this.transform.position = startPos;

            //Choose a new direction
            direction = new Vector3(1, Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f));
        }
    }
}
