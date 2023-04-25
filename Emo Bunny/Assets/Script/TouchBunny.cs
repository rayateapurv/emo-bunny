using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class TouchBunny : MonoBehaviour
{
    public GameObject FeedingPanel;
    public GameObject Bunny;

    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[1].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.touches[1].position);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.CompareTag("Bunny"))
                {
                 
                    FeedingPanel.SetActive(true);
                    }

                else
                    {
                        FeedingPanel.SetActive(false);
                    }
                }
            }
        }

    }   
   
