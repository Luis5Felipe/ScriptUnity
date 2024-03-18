using UnityEngine;

public class x2Zoom : MonoBehaviour
{
    public Camera cam;
    public float defaultFov = 90;
    public float zoomFov = 45; // Define o FOV para o zoom

    void Update()
    {
        // Verifica se a tecla "Z" está sendo pressionada
        if (Input.GetKey(KeyCode.Z))
        {
            // Aplica o zoom
            cam.fieldOfView = zoomFov;
            Debug.Log("Zoom ativado: FOV = " + cam.fieldOfView);
        }
        else
        {
            // Restaura o campo de visão padrão
            cam.fieldOfView = defaultFov;
            Debug.Log("Zoom desativado: FOV = " + cam.fieldOfView);
        }
    }
}
