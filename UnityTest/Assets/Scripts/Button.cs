using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Button : MonoBehaviour, IPointerExitHandler
{
    [SerializeField] private Color _color;

    private Image _image;

    private void Awake()
    {
        _image = GetComponent<Image>();
    }

    public void ChangeColor()
    {
        _image.color = _color;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        _image.color = Color.white;
    }
}
