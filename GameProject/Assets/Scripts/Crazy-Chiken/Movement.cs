using UnityEngine;

public class Movement : MonoBehaviour
{

    public float speed;
    public GameObject modeloCarzyChiken;
    public float rotationSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Transform transform = GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = Vector3.zero;

        // Movimiento
        if (Input.GetKey(KeyCode.W))
        {
            direction += Vector3.forward;
        }
        if (Input.GetKey(KeyCode.S))
        {
            direction += Vector3.back;
        }
        if (Input.GetKey(KeyCode.A))
        {
            direction += Vector3.left;
        }
        if (Input.GetKey(KeyCode.D))
        {
            direction += Vector3.right;
        }

        // Movimiento del objeto principal
        if (direction != Vector3.zero)
        {
            transform.position += direction.normalized * speed * Time.deltaTime;

            // Rotación del modelo 3D para que apunte en la dirección de movimiento
            Quaternion targetRotation = Quaternion.LookRotation(direction);
            modeloCarzyChiken.transform.rotation = Quaternion.RotateTowards(
                modeloCarzyChiken.transform.rotation,
                targetRotation,
                rotationSpeed * Time.deltaTime
            );
        }


    }
}
