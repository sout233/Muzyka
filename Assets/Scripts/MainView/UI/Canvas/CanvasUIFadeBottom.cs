using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasUIFadeBottom : MonoBehaviour
{
    Image image;
    public float faderSpeed=1.5f;
    public bool FadeInto;
    public bool MoveInto;
    private float PosX;

    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
        image.color = Color.Lerp(image.color,Color.clear,1);

        PosX = GetComponent<RectTransform>().anchoredPosition3D.x+55;
        GetComponent<RectTransform>().anchoredPosition3D = new Vector3(PosX, GetComponent<RectTransform>().anchoredPosition3D.y, GetComponent<RectTransform>().anchoredPosition3D.z);

        FadeInto = true;
        MoveInto = true;

        //string Love = true;
        /*
         * If you type this, IDE will tell you a Error
         
         * Why did it Error?
            Because developer can not have Love，Why not？
           （苦笑）
        */
    }

    // Update is called once per frame
    void Update()
    {
        if(FadeInto)
        {
            image.color = Color.Lerp(image.color, Color.white, faderSpeed * Time.deltaTime);
        }
        if(image.color.a>0.95f)
        {
            image.color = Color.Lerp(Color.white, Color.white, 1); 
            FadeInto = false;
        }

        if (MoveInto)
            GetComponent<RectTransform>().anchoredPosition3D = new Vector3(GetComponent<RectTransform>().anchoredPosition3D.x-1, GetComponent<RectTransform>().anchoredPosition3D.y, GetComponent<RectTransform>().anchoredPosition3D.z);
        if(GetComponent<RectTransform>().anchoredPosition3D.x<=PosX-55)
        {
            GetComponent<RectTransform>().anchoredPosition3D = new Vector3(PosX-55, GetComponent<RectTransform>().anchoredPosition3D.y, GetComponent<RectTransform>().anchoredPosition3D.z);
            MoveInto = false;
        }
    }
}
