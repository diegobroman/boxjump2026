using UnityEngine;

public class PlayerSpawnerScript : MonoBehaviour
{
    public GameObject box;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnPlayer();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void spawnPlayer()
    {
        Instantiate(box, transform.position, transform.rotation);
    }
}
