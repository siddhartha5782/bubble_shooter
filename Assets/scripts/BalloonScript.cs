using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonScript : MonoBehaviour
{
    //Random.Range(minVal, maxVal);
    // Start is called before the first frame update


    // Update is called once per frame

    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * Random.Range(0.5f,1.3f));
    }
}
