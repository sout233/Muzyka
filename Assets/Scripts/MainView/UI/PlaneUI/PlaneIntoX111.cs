using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneIntoX111 : MonoBehaviour
{
    public bool IntoX;
    
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<RectTransform>().anchoredPosition3D = new Vector3(111, 0, 0);
        IntoX = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(IntoX)
        {
            GetComponent<RectTransform>().anchoredPosition3D = new Vector3(GetComponent<RectTransform>().anchoredPosition3D.x-1, 0, 0);
        }

        if (GetComponent<RectTransform>().anchoredPosition3D.x <= 30)
            IntoX = false;
        
    }
}
