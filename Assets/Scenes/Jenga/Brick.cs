using System.Collections;
using System.Collections.Generic;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Access the Transform component of the GameObject
        Transform transform = this.transform;

        // Generate a random offset using Random.Range
        float randomOffset = Random.Range(-0.1f, 0.1f);
        
        // Calculate the new position by adding the random offset to the right vector
        Vector3 newPosition = transform.position + (transform.right * randomOffset);
        
        // Update the position of the GameObject
        transform.position = newPosition;

    }

 
}
