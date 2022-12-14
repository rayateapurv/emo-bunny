using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class buttonBehavior : MonoBehaviour
{
    public GameObject targetPanel;
    public GameObject currentPanel;
    public int targetScene;

    public void ChangeScene()
    {

        SceneManager.LoadScene(targetScene);
    }
    public void ChangePanel()
    {

        targetPanel.SetActive(true);
        currentPanel.SetActive(false);
    }
}
