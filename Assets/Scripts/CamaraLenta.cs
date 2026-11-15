using UnityEngine;

public class CamaraLenta : MonoBehaviour
{
    public float velocidadTiempo = 0.3f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("ObjetoCamaraLenta"))
        {
            Time.timeScale = velocidadTiempo;
        }
    }
}