using TMPro;
using UnityEngine;

public class EnemiesUI : MonoBehaviour
{
    TMP_Text text;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        text = GetComponent<TMP_Text>();
        EnemyManager.instance.onChanged.AddListener(RefreshText);
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Enemies: " + EnemyManager.instance.enemies.Count;
    }
}
