using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeInOut : MonoBehaviour
{
    public float faderSpeed = 1.5f;
    public bool sceneStarting = true;
    Image image;

    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
        image.color = Color.Lerp(image.color, Color.black, 1);
    }

    // Update is called once per frame
    void Update()
    {
        if (sceneStarting)
            StartScene();
    }

    private void FadeToClear()
    {
        image.color = Color.Lerp(image.color, Color.clear, faderSpeed * Time.deltaTime);
    }


    void StartScene()
    {
        FadeToClear();
        if (image.color.a < 0.05f)
        {
            image.color = Color.clear;
            sceneStarting = false;
        }
    }

}
