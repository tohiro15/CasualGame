using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Click : MonoBehaviour
{
    private int _clicks = 0;
    private TextMeshProUGUI _counter;

    private void Start()
    {
        _counter = GetComponent<TextMeshProUGUI>();
    }
    private void Update()
    {
        _counter.text = $"{_clicks} кликов";
    }

    public void OnClicked()
    {
        _clicks++;
    }
}
