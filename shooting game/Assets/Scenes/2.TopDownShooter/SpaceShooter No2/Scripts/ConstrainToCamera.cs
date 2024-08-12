using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstrainToCamera : MonoBehaviour
{
    public Camera camera; // Assign the camera in the inspector or dynamically
    public Vector2 padding = new Vector2(0.1f, 0.1f); // Padding to keep player from touching the screen edges

    private void Update()
    {
        if (camera == null)
        {
            Debug.LogError("Camera is not assigned.");
            return;
        }

        // Convert player's world position to viewport position
        Vector3 viewportPosition = camera.WorldToViewportPoint(transform.position);

        // Get the viewport bounds considering padding
        float minX = padding.x;
        float maxX = 1 - padding.x;
        float minY = padding.y;
        float maxY = 1 - padding.y;

        // Clamp the viewport position
        viewportPosition.x = Mathf.Clamp(viewportPosition.x, minX, maxX);
        viewportPosition.y = Mathf.Clamp(viewportPosition.y, minY, maxY);

        // Convert the clamped viewport position back to world position
        transform.position = camera.ViewportToWorldPoint(viewportPosition);
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z); // Ensure z position is preserved
    }
}
