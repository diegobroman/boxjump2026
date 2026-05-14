using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class levelTransitionTriggerScript : MonoBehaviour
{
    public string levelToLoad;
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
        if (collision.gameObject.layer == 7)
        {
            SceneManager.LoadScene(levelToLoad);
        }

    }
}
