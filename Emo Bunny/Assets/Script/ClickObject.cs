using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickObject : MonoBehaviour
{
    public GameObject panel;//����
    public Button closeButton;//�رհ�ť
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
        if (panel.activeSelf == false) //����û����ʱ������
        {
            panel.SetActive(true);
        }
    }
    public void CilckButtonClose() //�رս���
    {
        panel.SetActive(false);
    }
}
