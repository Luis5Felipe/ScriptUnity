using UnityEngine;

public class FPSController : MonoBehaviour
{
    private Animator anim;
    public float speed = 10000000; // Ajuste este valor para controlar a velocidade de movimento

    [HideInInspector]
    public float inputX, inputZ;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        inputX = Input.GetAxis("Horizontal");
        inputZ = Input.GetAxis("Vertical");

        anim.SetFloat("Horizontal", inputX);
        anim.SetFloat("Vertical", inputZ);

        // Movimentação do personagem
        Vector3 movement = new Vector3(inputX, 0, inputZ) * speed * Time.deltaTime;
        transform.Translate(movement);
    }
}
