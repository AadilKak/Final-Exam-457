using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurveMove : MonoBehaviour
{
    public float radius = 5.0f; // Circular path radius
    public float speed = 1.0f; // Speed of movement
    public Material lineMaterial; // Assign a material for the line in the Inspector

    private LineRenderer lineRenderer;
    private int pointIndex = 0;

    void Update()
    {
        // Initialize the LineRenderer if it hasn't been done yet
        if (lineRenderer == null)
        {
            InitializeLineRenderer();
        }

        // Calculate the new position in a circular path
        float x = Mathf.Cos(Time.time * speed) * radius;
        float z = Mathf.Sin(Time.time * speed) * radius;
        Vector3 newPosition = new Vector3(x, transform.position.y, z);

        // Set the object's position
        transform.position = newPosition;

        // Add the new position to the LineRenderer
        AddPointToLineRenderer(newPosition);

        // Rotate object around its own Y-axis
        transform.Rotate(Vector3.up, speed * 50 * Time.deltaTime);
    }

    private void InitializeLineRenderer()
    {
        lineRenderer = gameObject.AddComponent<LineRenderer>();
        lineRenderer.positionCount = 0; // Start with no points
        //lineRenderer.material = lineMaterial ?? new Material(Shader.Find("Sprites/Default")); // Use default material if none is assigned
        lineRenderer.startColor = Color.white;
        lineRenderer.endColor = Color.white;
        lineRenderer.startWidth = 0.1f;
        lineRenderer.endWidth = 0.1f;
    }

    private void AddPointToLineRenderer(Vector3 position)
    {
        pointIndex++;
        lineRenderer.positionCount = pointIndex;
        lineRenderer.SetPosition(pointIndex - 1, position);
    }
}
