using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeText : MonoBehaviour
{
    private string month,day,hour,minute,second;

    // Start is called before the first frame update
    void Start()
    {
        month = DateTime.Now.Month.ToString();
        day = DateTime.Now.Day.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        hour = DateTime.Now.Hour.ToString();
        minute = DateTime.Now.Minute.ToString();
        second = DateTime.Now.Second.ToString();

        GetComponent<TextMesh>().text = string.Format("{0:D2}/{1:D2} {2:D2}:{3:D2}:{4:D2}", month,day, hour, minute, second);
    }
}
