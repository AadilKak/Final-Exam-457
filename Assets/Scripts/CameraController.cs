using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        // Transform is a standard Unity object, coming directly from the editor
        offset = transform.position - player.transform.position;
    }

    // LateUpdate is called after all Update functions have been called. Camers should always be implemented in LateUpdate
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
