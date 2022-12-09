using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PropBehaviors : MonoBehaviour
{
    public int propPrice;
    public int propName;
    public GameObject buyThisPanel;
    public GameObject takeThisPanel;
    public GameObject propPanel;
    public GameObject cantAffordPanel;
    public GameObject TextPanel;
    int chocoNumber;
    public Text chocoNumberText;
    public Text propReference;
    public bool buyButton=false;

    void Start()
    {
    }
    void Update()
    {       
    }

    public void BuyProp()
    {
        chocoNumber = int.Parse(chocoNumberText.text.ToString());
        for (int i = 0; i < TextPanel.transform.childCount; i++)
        {
            TextPanel.transform.GetChild(i).gameObject.SetActive(false);
        }
        if (propPrice <= chocoNumber)
        {
            buyThisPanel.SetActive(true);
            propReference.text = propName.ToString();
        }   
        else
        {
            cantAffordPanel.SetActive(true);
        }
    }
    public void PayChoco()
    {
        if (propReference.text== propName.ToString())
        {
            chocoNumber = int.Parse(chocoNumberText.text.ToString());
            chocoNumber -= propPrice;
            chocoNumberText.text = chocoNumber.ToString();
            for (int i = 0; i < TextPanel.transform.childCount; i++)
            {
                TextPanel.transform.GetChild(i).gameObject.SetActive(false);
            }
            takeThisPanel.SetActive(true);
            propPanel.SetActive(true);
            transform.gameObject.SetActive(false);
        }
    }
    public void TakeProp()
    {
            for (int i = 0; i < TextPanel.transform.childCount; i++)
            {
                TextPanel.transform.GetChild(i).gameObject.SetActive(false);
            }
            takeThisPanel.SetActive(true);
    }

}
