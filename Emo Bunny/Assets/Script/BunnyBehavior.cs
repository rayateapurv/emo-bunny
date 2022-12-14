using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BunnyBehavior : MonoBehaviour
{
    public string state = "base";
    public float baseTime = 0;
    public float hungerLimit = 10;
    public float hungerTime = 0;
    public float poopTime = 0;
    public float poopLimit = 20;

    public GameObject feedPanel;

    public Slider angerSlider;
    public Slider joySlider;
    public Slider fearSlider;
    public Slider sadSlider;
    public Slider disgustSlider;

    public GameObject poop1, poop2, poop3;

    public List<float> emotions =  new List<float>();

    public float range = 200f;

    public int chocoNum = 10;
    public Text chocoUI;

    public Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(state == "base")
        {
            if (baseTime < hungerLimit)
            {
                baseTime += Time.deltaTime;
            }
            else
            {
                state = "hungry";
            }
        }

        if (state == "hungry")
        {
            if (hungerTime < hungerLimit * 4)
            {
                hungerTime += Time.deltaTime;
            }
            else
            {
                state = "hibernate";
            }
        }

        if (state == "fed")
        {
            if (poopTime < poopLimit)
            {
                poopTime += Time.deltaTime;
            }
            else
            {
                state = "base";
                Poop();
                poopTime = 0;
            }
        }



        Collect();
        chocoUI.text = chocoNum.ToString();

    }

    void Poop()
    {
        int ran = Random.Range(1, 4);
        if (ran == 1)
        {
            Instantiate(poop1, new Vector3(Random.Range(-300.0f, 300.0f), -50.0f, Random.Range(250.0f, 400.0f)), Quaternion.identity);
        }
        else if (ran == 2)
        {
            Instantiate(poop2, new Vector3(Random.Range(-300.0f, 300.0f), -50.0f, Random.Range(250.0f, 400.0f)), Quaternion.identity);
        }
        else if (ran == 3)
        {
            Instantiate(poop3, new Vector3(Random.Range(-300.0f, 300.0f), -50.0f, Random.Range(250.0f, 400.0f)), Quaternion.identity);
        }
    }

    void Collect()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 100f;
        mousePos = cam.ScreenToWorldPoint(mousePos);

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, range))
            {
                Debug.Log(hit.transform.tag);
                Debug.Log(chocoNum);

                if (hit.transform.tag == "choco")
                {
                    GameObject food = hit.transform.gameObject;
                    Destroy(food);

                    chocoNum++;

                }

            }
        }
    }

    private void OnMouseDown()
    {
        if (state != "fed")
        {
            feedPanel.SetActive(true);
        }
        
    }

    public void Quit()
    {
        feedPanel.SetActive(false);
    }

    public void Feed()
    {
        state = "fed";
        emotions.Clear();
        emotions.Add(angerSlider.value);
        emotions.Add(joySlider.value);
        emotions.Add(fearSlider.value);
        emotions.Add(sadSlider.value);
        emotions.Add(disgustSlider.value);
        feedPanel.SetActive(false);
    }
}
