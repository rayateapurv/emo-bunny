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
        foreach (Touch touch in Input.touches)
        {
            if (touch.phase == TouchPhase.Began)
            {
                Ray ray = Camera.main.ScreenPointToRay(touch.position);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.collider.tag== "Bunny")
                    {
                        panel.SetActive(true);
                    }

                    // �ڴ˴�ʵ�ֶ�����Ľ�������
                }
            }
        }
    }

    public void CilckButtonClose() //�رս���
    {
        panel.SetActive(false);
    }
}
