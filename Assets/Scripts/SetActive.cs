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
        if (_isshow)
        {
            _image.GameObject().SetActive(false);
            _isshow = false;
        }
        else if (!_isshow)
        {
            _image.GameObject().SetActive(true);
            _isshow = true;
        }
        
    }

}
