using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comprimido : MonoBehaviour
{
    float unitX, unitZ;
    float v;

    // Start is called before the first frame update
    void Start()
    {
        v = 6.0f;    
    }

    // Update is called once per frame
    void Update()
    {
        unitX = Input.GetAxis("Horizontal") * v * Time.deltaTime;
        unitZ = Input.GetAxis("Vertical") * v * Time.deltaTime;
        transform.Translate(unitX, 0, unitZ);
    }
}
