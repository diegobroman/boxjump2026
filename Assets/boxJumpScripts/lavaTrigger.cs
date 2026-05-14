using UnityEngine;
using UnityEngine.SceneManagement;

public class lavaTrigger : MonoBehaviour
{
    public GameObject player;
    public GameObject spawnPoint;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject currentPlayer = GameObject.FindGameObjectWithTag("Player");
        spawnPoint = GameObject.FindGameObjectWithTag("SpawnPoint");
        if (collision.gameObject.layer == 7 && player)
        {
            Destroy(currentPlayer);
            Instantiate(player, spawnPoint.transform.position, spawnPoint.transform.rotation);
        }

    }
}
