
using Unity.Cinemachine;
using UnityEngine;

public class SacudidaCamara : MonoBehaviour
{
    private CinemachineImpulseSource impulseSource;

    void Start()
    {
        impulseSource = GetComponent<CinemachineImpulseSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            impulseSource.GenerateImpulse();
        }
    }
}
