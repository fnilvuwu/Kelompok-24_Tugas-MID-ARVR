using UnityEngine;
using UnityEngine.SceneManagement;

public class ClassDoorCollision3D : MonoBehaviour
{
    [SerializeField]
    private string nextSceneName = "SchoolScene"; // Name of the scene to load, you can set this in the Inspector too

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger Detected");  // Log when something enters the trigger

        if (other.CompareTag("Player"))
        {
            Debug.Log("Player entered the trigger");  // Log when the player enters the trigger
            SceneManager.LoadScene(nextSceneName);
        }
        else
        {
            Debug.Log("Something else entered the trigger: " + other.gameObject.name);
        }
    }
}
