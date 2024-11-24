using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NameEntry : MonoBehaviour
{
    [SerializeField] private TMP_InputField _inputField;

    public GameObject LoadMenu;
    private void Start()
    {
        _inputField = GetComponentInChildren<TMP_InputField>();
    }
    public void OnClickedIsAccept()
    {
        gameObject.SetActive(false);
        LoadMenu.SetActive(true);
        GameManager.PlayerName = _inputField.text;
    }
}
