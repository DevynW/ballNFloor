using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class placeMe : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float x = Random.Range(-7f,7f);
        float y = Random.Range(-4f, 4f);
        float z = Random.Range(-5f, 5f);
        float a = Random.Range(-5f, 5f);

        Vector3 myPosition = new Vector3(x,y,0f);
        transform.position = myPosition;

        Rigidbody2D rb;
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(a, z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
