using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Signup2Button : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonBack()
    {
        SceneManager.LoadScene(0);
    }

    public void ButtonDone()
    {
        SceneManager.LoadScene(2);
    }
}
