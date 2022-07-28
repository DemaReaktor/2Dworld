using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraImageController : MonoBehaviour
{
    private RectTransform rectTransform;
    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        rectTransform.sizeDelta = new Vector2(Screen.width,Screen.height);
    }
}
