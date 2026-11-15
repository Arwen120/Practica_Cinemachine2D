using UnityEngine;

public class CambiarCamara : MonoBehaviour
{
    public GameObject camara1;
    public GameObject camara2;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            ActivarCamara1();
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            ActivarCamara2();
        }
    }

    public void ActivarCamara1()
    {
        camara1.SetActive(true);
        camara2.SetActive(false);
    }

    public void ActivarCamara2()
    {
        camara1.SetActive(false);
        camara2.SetActive(true);
    }
}