
using UnityEngine;

public class MovimientoAutomatico : MonoBehaviour
{
    public Vector3 direccion = Vector3.right;
    public float distancia = 2f;
    public float velocidad = 1f;

    private Vector3 posicionInicial;

    void Start()
    {
        posicionInicial = transform.position;
    }

    void Update()
    {
        float movimiento = Mathf.Sin(Time.time * velocidad) * distancia;

        transform.position = posicionInicial + direccion.normalized * movimiento;
    }
}
