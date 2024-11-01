using UnityEngine;
using UnityEngine.EventSystems;

public class Brick : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    private Rigidbody rb;

    void Start()
    {
        // Get the Rigidbody component at the start
        rb = GetComponent<Rigidbody>();
    }

    public void OnDrag(PointerEventData eventData)
    {
        // Create a plane at the height of the brick
        Plane plane = new Plane(Vector3.up, Vector3.up * transform.position.y);
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); // Use eventData.position

        if (plane.Raycast(ray, out float distance))
        {
            // Move the brick to the new position based on the raycast
            transform.position = ray.GetPoint(distance);
        }
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        // Set Rigidbody to kinematic to prevent physics interference
        if (rb != null)
        {
            rb.isKinematic = true;
        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        // Reset kinematic state
        if (rb != null)
        {
            rb.isKinematic = false;
        }
    }
}