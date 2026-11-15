using UnityEngine;
using Unity.Cinemachine;

public class CambiarConfiner : MonoBehaviour
{
    public CinemachineConfiner2D confiner;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("ObjetoCambiarConfiner"))
        {
            confiner.enabled = !confiner.enabled;
        }
    }
}
