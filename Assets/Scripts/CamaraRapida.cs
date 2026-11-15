using UnityEngine;

public class CamaraRapida : MonoBehaviour
{
    public float velocidadTiempo = 2f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("ObjetoCamaraRapida"))
        {
            Time.timeScale = velocidadTiempo;
        }
    }
}
