using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DualAxisExample : MonoBehaviour
{
   
    public float hRange;
    public float vRange;
     void Start()
    {

    }
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        float xPos = h * hRange;
        float yPos = v * vRange;

        transform.position = new Vector3(xPos, 0, yPos);
        Debug.Log(h.ToString("F2"));
        Debug.Log(v.ToString("F2"));
    }
}
