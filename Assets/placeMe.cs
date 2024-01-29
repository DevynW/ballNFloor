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

        Vector3 myPosition = new Vector3(x,y,0f);
        transform.position = myPosition;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
