using UnityEngine;

public class TimeEffectTrigger : MonoBehaviour
{
    [SerializeField] private GameObject player;       // Referencia al jugador
    [SerializeField] private bool cameraFast;         // True para cámara lenta, false para cámara rápida
    [SerializeField] private bool cameraSlow;  

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Verificar si el objeto que colisiona es el jugador
        if (!other.gameObject.Equals(player)) 
            return;

        // Cambiar la escala de tiempo según el estado de cameraFast
        if (cameraSlow)
        {
            // Activar cámara lenta
            Time.timeScale = 0.5f; // Factor para cámara lenta
        }
        if (cameraFast)
        {
            // Activar cámara rápida
            Time.timeScale = 2.0f; // Factor para cámara rápida
        }

        Time.fixedDeltaTime = 0.02f * Time.timeScale; // Ajustar fixedDeltaTime para mantener la simulación consistente
    }
}

