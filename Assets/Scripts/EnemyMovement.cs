using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public enum Direction
    {
        Derecha,
        Izquierda,
        DiagonalDerecha,
        DiagonalIzquierda
    }

    [SerializeField] private Direction moveDirection; // Desplegable para seleccionar la dirección
    [SerializeField] private float moveSpeed = 5f;

    private Vector3 _movement;

    private void Start()
    {
        // Establecer el vector de movimiento según la dirección seleccionada
        switch (moveDirection)
        {
            case Direction.Derecha:
                _movement = Vector3.right;
                break;

            case Direction.Izquierda:
                _movement = Vector3.left;
                break;

            case Direction.DiagonalDerecha:
                _movement = new Vector3(1, 1, 0).normalized;
                break;

            case Direction.DiagonalIzquierda:
                _movement = new Vector3(-1, 1, 0).normalized;
                break;
        }
    }

    private void Update()
    {
        // Mover el objeto en la dirección seleccionada
        transform.Translate(_movement * moveSpeed * Time.deltaTime);
    }
}

