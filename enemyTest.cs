using JetBrains.Annotations;
using UnityEngine;

public class enemyTest : MonoBehaviour
{
float health;

void DestroySlef()
{
    Destroy(gameObject);
}

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke("DestroySelf", 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

