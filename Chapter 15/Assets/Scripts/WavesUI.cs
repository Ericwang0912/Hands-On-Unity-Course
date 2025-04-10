using TMPro;
using UnityEngine;

public class WavesUI : MonoBehaviour
{
    TMP_Text text;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        text = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void RefreshText()
    {
        text.text = "Remaining Waves: " + WaveManager.instance.waves.Count;
    }
}
