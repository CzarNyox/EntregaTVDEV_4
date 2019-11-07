using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTankController : MonoBehaviour
{

    public float speed = 4;
    public float angularSpeed = 30f;

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up * (-angularSpeed * Time.deltaTime));
        }else if(Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * (angularSpeed * Time.deltaTime));
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * (speed * Time.deltaTime));
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * (speed * Time.deltaTime));
        }
    }
}
