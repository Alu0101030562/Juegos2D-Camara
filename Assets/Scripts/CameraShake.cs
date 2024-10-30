using UnityEngine;

public class CameraShake : MonoBehaviour
{
    private Cinemachine.CinemachineImpulseSource _impulseSource;

    void Start()
    {
        _impulseSource = GetComponent<Cinemachine.CinemachineImpulseSource>();
        Invoke(nameof(TriggerExplosion), 1);
    }

    public void TriggerExplosion()
    {
        _impulseSource.GenerateImpulse();
    }
}
