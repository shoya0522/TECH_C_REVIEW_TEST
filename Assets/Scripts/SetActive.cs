using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SetActive : MonoBehaviour
{
    [SerializeField] private Image _image;
    [SerializeField] private Button _button;

    private bool _isshow = true;
    private void Start()
    {
        _button.onClick.AddListener(onClick);
    }
    private void onClick()
    {
        _isshow = !_isshow;
        _image.GameObject().SetActive(_isshow);
    }

}
