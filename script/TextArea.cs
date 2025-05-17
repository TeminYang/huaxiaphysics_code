using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextArea : MonoBehaviour
{
    private RectTransform rect;
    private RectTransform Arearect;
    private UnityEngine.UI.Slider slider;

    [System.Obsolete]
    private void Awake()
    {
        rect = this.GetComponent<RectTransform>();
        Arearect = this.transform.FindChild("Area").GetComponent<RectTransform>();
        slider = this.transform.FindChild("Slider").GetComponent<UnityEngine.UI.Slider>();
    }
    private void Update()
    {
        float tempArearectPosY = slider.value * Arearect.sizeDelta.y;
        Arearect.anchoredPosition = new Vector2(Arearect.anchoredPosition.x, tempArearectPosY);
    }
}
