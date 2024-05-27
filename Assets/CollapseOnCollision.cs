using UnityEngine;

public class CollapseOnCollision : MonoBehaviour
{
    private bool shouldCollapse = false; 
    private float rotationSpeed = 20f;

    private void Update()
    {
        if (shouldCollapse)
        {
      
            transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {

            shouldCollapse = true;
        }
    }
}
