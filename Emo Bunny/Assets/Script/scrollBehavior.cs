using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class scrollBehavior : MonoBehaviour
{
    ScrollRect rect;
    public void ScrollPosition()
    {
        rect.horizontalNormalizedPosition = Mathf.Lerp(0f, 1f, 1 / 24 * 5f);
    }

}
