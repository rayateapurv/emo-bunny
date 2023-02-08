using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchBunny : MonoBehaviour
{
    public GameObject FeedingPanel;

    public void whenButtonClicked()
    {
        if (FeedingPanel.activeInHierarchy == true)
            FeedingPanel.SetActive(false);
        else
            FeedingPanel.SetActive(true);
    }
   
}