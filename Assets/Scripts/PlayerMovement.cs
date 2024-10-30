using UnityEngine;

public class PlayerMovementSimple : MonoBehaviour
{
    public float moveSpeed = 10f;

    void Update()
    {
        // Obtiene la entrada del teclado (A, D)
        float moveInput = Input.GetAxisRaw("Horizontal");
        
        // Mueve el objeto
        transform.Translate(Vector3.right * moveInput * moveSpeed * Time.deltaTime);
    }
}