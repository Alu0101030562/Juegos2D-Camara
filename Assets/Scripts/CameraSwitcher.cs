using UnityEngine;
using Cinemachine;

public class CameraSwitcher : MonoBehaviour
{
    [SerializeField] private CinemachineBrain cinemachineBrain;
    [SerializeField] private CinemachineVirtualCamera camera1;
    [SerializeField] private CinemachineVirtualCamera camera2;

    private void Update()
    {
        // Cambia a camera1 si se presiona la tecla "1" y no está activa
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            if (!camera1.gameObject.activeSelf)
            {
                SetActiveCamera(camera1, camera2);
            }
        }
        // Cambia a camera2 si se presiona la tecla "2" y no está activa
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            if (!camera2.gameObject.activeSelf)
            {
                SetActiveCamera(camera2, camera1);
            }
        }
    }

    private void SetActiveCamera(CinemachineVirtualCamera cameraToActivate, CinemachineVirtualCamera cameraToDeactivate)
    {
        // Desactiva la cámara actualmente activa y activa la nueva cámara
        cameraToDeactivate.gameObject.SetActive(false);
        cameraToActivate.gameObject.SetActive(true);
    }
}