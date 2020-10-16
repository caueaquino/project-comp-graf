using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tomar : MonoBehaviour
{

    float unitX, unitY;
    float v;
    public GameObject pers;

    // Start is called before the first frame update
    void Start()
    {
        v = 50f;
        unitX = 0f;
        Cursor.lockState = CursorLockMode.Locked;        
    }

    // Update is called once per frame
    void Update()
    {
        unitX += Input.GetAxis("Mouse Y") * v * Time.deltaTime;
        unitX = Mathf.Clamp(unitX, -60f, 60f);
        transform.localEulerAngles = new Vector3(-unitX, 0, 0);
        unitY += Input.GetAxis("Mouse X") * v * Time.deltaTime;
        pers.transform.Rotate(0, unitY, 0);
    }
}
