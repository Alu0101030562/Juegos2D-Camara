using Cinemachine;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera vcam;
    [SerializeField] private float zoomSpeed = 5f;  // Velocidad del zoom
    [SerializeField] private float minZoom = 2f;    // Zoom mínimo (OrthographicSize más pequeño)
    [SerializeField] private float maxZoom = 10f;   // Zoom máximo (OrthographicSize más grande)

    private void Update()
    {
        // Si se presiona "S", aleja el zoom
        if (Input.GetKey(KeyCode.S))
        {
            vcam.m_Lens.OrthographicSize += zoomSpeed * Time.deltaTime;
        }
        // Si se presiona "W", acerca el zoom
        else if (Input.GetKey(KeyCode.W))
        {
            vcam.m_Lens.OrthographicSize -= zoomSpeed * Time.deltaTime;
        }

        // Limitar el valor de OrthographicSize entre _minZoom y _maxZoom
        vcam.m_Lens.OrthographicSize = Mathf.Clamp(vcam.m_Lens.OrthographicSize, minZoom, maxZoom);
    }
}
