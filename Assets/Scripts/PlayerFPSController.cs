using UnityEngine;

public class PlayerFPSController : MonoBehaviour
{

    public GameObject camerasParent;
    public float walkSpeed = 5f;
    public float hRotationSpeed = 100F;
    public float vRotationSpeed = 80f;

    void Start()
    {
        //Ocultar y bloquear el cursor
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        GameObject.Find("Capsule").GetComponent<MeshRenderer>().enabled = false;
    }

    void Update()
    {
        movement();
    }

    private void movement()
    {
        //Transform
        float hMovement = Input.GetAxisRaw("Horizontal");
        float vMovement = Input.GetAxisRaw("Vertical");

        Vector3 movementDirection = hMovement * Vector3.right + vMovement * Vector3.forward;
        transform.Translate(movementDirection * (walkSpeed * Time.deltaTime));

        //Rotation
        float vCamRotation = Input.GetAxis("Mouse Y") * vRotationSpeed * Time.deltaTime;
        float hPlayerRotation = Input.GetAxis("Mouse X") * hRotationSpeed * Time.deltaTime;

        transform.Rotate(0f, hPlayerRotation, 0f);
        camerasParent.transform.Rotate(-vCamRotation, 0f, 0f);
    }
}
