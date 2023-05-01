using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickObject : MonoBehaviour
{
    public GameObject panel;//界面
    public Button closeButton;//关闭按钮
    void Start()
    {
        closeButton.onClick.AddListener(CilckButtonClose); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnMouseDown()
    {
        if (panel.activeSelf == false) //界面没激活时，激活
        {
            panel.SetActive(true);
        }
    }
    public void CilckButtonClose() //关闭界面
    {
        panel.SetActive(false);
    }
}
