using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Oh, oh the misery!
    void Start()
    {
        EnemyManager.instance.enemies.Add(this);
    }

    void OnDestroy()
    {
        EnemyManager.instance.enemies.Remove(this);
    }
}
