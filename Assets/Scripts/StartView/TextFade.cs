using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextFade : MonoBehaviour
{
    public float faderSpeed = 1.5f;
    public bool FadeWhite = false;
    public bool FadeClear = true;
    public Text text1;

    // Start is called before the first frame update
    void Start()
    {
        text1 = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (FadeClear)
            FadeTextToClear();
        if (FadeWhite)
            FadeTextToWhite();
    }

    void FadeTextToWhite()
    {
        FadeToClear();
        if (text1.color.a < 0.05f)
        {
            text1.color = new Color(1,1,1,0);
            FadeWhite = false;
            FadeClear = true;
        }
    }

    void FadeTextToClear()
    {
        FadeToBlack();
        if (text1.color.a > 0.95f)
        {
            text1.color = Color.white;
            FadeClear = false;
            FadeWhite = true;
        }
    }

    void FadeToClear()
    {
        text1.color = Color.Lerp(text1.color, new Color(1,1,1,0), faderSpeed * Time.deltaTime);
    }

    void FadeToBlack()
    {
        text1.color = Color.Lerp(text1.color, Color.white, faderSpeed * Time.deltaTime);
    }
}
