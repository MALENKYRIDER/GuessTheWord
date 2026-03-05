using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] private Button _menuButton;
    [SerializeField] private GameObject _menu;
    [SerializeField] private Slider _volumeSlider;
    [SerializeField] private TMP_InputField _inputField;
    [SerializeField] private Toggle _toggle;

    private void Start()
    {
        _menu.SetActive(false);
    }

    private void OnEnable()
    {
        _menuButton.onClick.AddListener(OnMenuClick);
        _volumeSlider.onValueChanged.AddListener(OnVolumeChanged);
        _inputField.onValueChanged.AddListener(OnInputChanged);
        _toggle.onValueChanged.AddListener(OnToggleChanged);
    }



    private void OnDisable()
    {
        _menuButton.onClick.RemoveListener(OnMenuClick);
        _volumeSlider.onValueChanged.RemoveListener(OnVolumeChanged);
    }
    private void OnToggleChanged(bool value)
    {
        Debug.Log(value);
    }

    private void OnMenuClick()
    {
        _menu.SetActive(!_menu.activeSelf);
    }

    private void OnVolumeChanged(float volume)
    {
        Debug.Log($"Volume: {volume}");
    }

    private void OnInputChanged(string text)
    {
        Debug.Log(text);
    }
}