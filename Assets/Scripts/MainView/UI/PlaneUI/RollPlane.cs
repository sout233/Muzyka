using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollPlane : MonoBehaviour
{
    public bool Rolling;
    public bool Stretching;
    float ScaleX;
    // Start is called before the first frame update
    void Start()
    {
        ScaleX = transform.localScale.x;
        transform.localEulerAngles = new Vector3((float)270.9996, (float)183.71, 180);
        //transform.localScale = new Vector3(0, transform.localScale.y, transform.localScale.z);
        Rolling = true;
        Stretching = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Rolling)
            transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y, (float)(transform.localEulerAngles.z - 0.2));      
        if (transform.localEulerAngles.z<= 163)
            Rolling = false;

        if(Stretching)
            transform.localScale = new Vector3((float)(transform.localScale.x + 0.3), transform.localScale.y, transform.localScale.z);
        if (transform.localScale.x >= ScaleX)
            Stretching = false;
    }
}
