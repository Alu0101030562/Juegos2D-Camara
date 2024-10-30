using Cinemachine;
using UnityEngine;

public class CameraTransition : MonoBehaviour
{
    [SerializeField] private CinemachineBrain cinemachineBrain;
    [SerializeField] private CinemachineVirtualCamera vcam;
    
    [SerializeField] private GameObject player;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.gameObject.Equals(player))
            return;

        cinemachineBrain.ActiveVirtualCamera.Priority = 9;
        vcam.Priority = 10;
    }
}
