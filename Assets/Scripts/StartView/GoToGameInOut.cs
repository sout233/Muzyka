using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GoToGameInOut : MonoBehaviour
{
    //动画定义
    public float faderSpeed = 1.5f;
    public bool sceneStarting = true;
    public bool sceneEnd = false;
    Image image;

    //图片名字
    string imageName;
    //预制体对象
    GameObject part;

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

        if (Input.GetMouseButtonDown(0))
        {
            //如果获取到对象的话
            if (OnePointColliderObject() != null)
            {
                //给图片名字赋值
                imageName = OnePointColliderObject().name;
                //跳转场景
                MainScene();
            }
        }

        if(sceneEnd)
        {
            EndScene();
        }
    }

    public GameObject OnePointColliderObject()
    {
        //存有鼠标或者触摸数据的对象
        PointerEventData eventDataCurrentPosition = new PointerEventData(EventSystem.current);
        //当前指针位置
        eventDataCurrentPosition.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        //射线命中之后的反馈数据
        List<RaycastResult> results = new List<RaycastResult>();
        //投射一条光线并返回所有碰撞
        EventSystem.current.RaycastAll(eventDataCurrentPosition, results);
        //返回点击到的物体
        if (results.Count > 0)
            return results[0].gameObject;
        else
            return null;
    }

    public void MainScene()
    {
        switch (imageName)
        {
            case "BlackGround":
                sceneEnd = true;
                break;

            case "Background":
                sceneEnd = true;
                break;

            default:
                break;
        }
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

    void EndScene()
    {
        FadeToBlack();
        if (image.color.a > 0.95f)
            SceneManager.LoadScene(1);
    }

    void FadeToBlack()
    {
        image.color = Color.Lerp(image.color, Color.black, faderSpeed * Time.deltaTime);
    }
}
