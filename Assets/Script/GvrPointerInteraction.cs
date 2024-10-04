using UnityEngine;

public class GvrPointerInteraction : MonoBehaviour
{
    public GameObject podium;  // Assign your podium model in the Inspector
    public Canvas infoCanvas;  // Assign the Canvas UI element in the Inspector

    private Camera mainCamera;

    void Start()
    {
        mainCamera = Camera.main; // Get the main camera for raycasting
        infoCanvas.gameObject.SetActive(false);  // Ensure Canvas is hidden by default
    }

    void Update()
    {
        // Perform a raycast from the camera forward
        Ray ray = new Ray(mainCamera.transform.position, mainCamera.transform.forward);
        RaycastHit hit;

        // If the raycast hits an object within 100 meters
        if (Physics.Raycast(ray, out hit, 100))
        {
            // Check if the object hit is the podium
            if (hit.collider.gameObject == podium)
            {
                // Show the Canvas UI when aiming at the podium
                infoCanvas.gameObject.SetActive(true);
                Debug.Log("Pointer is on the podium, showing Canvas.");
            }
            else
            {
                // Hide the Canvas if we're not aiming at the podium
                infoCanvas.gameObject.SetActive(false);
            }
        }
        else
        {
            // If nothing is hit, hide the Canvas
            infoCanvas.gameObject.SetActive(false);
        }
    }
}
