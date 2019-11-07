using UnityEngine;

public class CapsuleRotation : MonoBehaviour
{
    [SerializeField]
    public float angularSpeed;

    void Update()
    {
        transform.Rotate(Vector3.up * (angularSpeed * Time.deltaTime));
    }
}


