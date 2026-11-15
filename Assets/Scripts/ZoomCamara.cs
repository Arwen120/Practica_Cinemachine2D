using UnityEngine;
using Unity.Cinemachine;

public class ZoomCamara : MonoBehaviour
{
    public float velocidadZoom = 2f;
    public float zoomMinimo = 3f;
    public float zoomMaximo = 10f;

    private CinemachineCamera camara;

    void Start()
    {
        camara = GetComponent<CinemachineCamera>();
    }

    void Update()
    {
        float cambio = 0f;

        if (Input.GetKey(KeyCode.W))
        {
            cambio = -velocidadZoom * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            cambio = velocidadZoom * Time.deltaTime;
        }

        var lente = camara.Lens;
        lente.OrthographicSize = Mathf.Clamp(
            lente.OrthographicSize + cambio,
            zoomMinimo,
            zoomMaximo
        );
        camara.Lens = lente;
    }
}