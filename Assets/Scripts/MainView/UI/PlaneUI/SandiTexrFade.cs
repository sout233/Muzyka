using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SandiTexrFade : MonoBehaviour
{
    public bool FadeInto;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<TextMesh>().color = Color.Lerp(new Color(1, 1, 1, 0), Color.white, 0);
        FadeInto = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(FadeInto)
        {
            GetComponent<TextMesh>().color = Color.Lerp(new Color(1, 1, 1, 0), Color.white, (float)(GetComponent<TextMesh>().color.a + 0.02));
        }
        if(GetComponent<TextMesh>().color.a>0.95)
        {
            GetComponent<TextMesh>().color = Color.white;
            FadeInto = false;
        }
    }
}
