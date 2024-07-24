using UnityEngine;

public class Example : MonoBehaviour
{
    void Start()
    {
        // Initialize a new Bounds object with default constructor
        Bounds b = new Bounds();

        // Optionally, you can initialize Bounds with a center and size
        // Vector3 center = new Vector3(0, 0, 0);
        // Vector3 size = new Vector3(1, 1, 1);
        // Bounds b = new Bounds(center, size);

        Debug.Log(b);
    }
}
