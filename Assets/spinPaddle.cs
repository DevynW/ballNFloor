using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinPaddle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 0f, .3f);
        transform.Translate(.001f, 0f, 0f);
    }
}
