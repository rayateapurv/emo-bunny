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
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
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
