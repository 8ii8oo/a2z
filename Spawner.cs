using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] gmaeObjects;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke("Spawn", 2f);
    }
void Spawn(){
    var randomObject = gmaeObjects[Random.Range(0, gmaeObjects.Length)];
    Instantiate(randomObject, transform.position, Quaternion.identity);
    Invoke("Spawn", 2f);
}

}
