using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{

    public GameObject camerasParent;        //Parent object of all cameras that should rotate with mouse
    public float hRotationSpeed = 100f;     //Player rotates along Y axis
    public float vRotationSpeed = 80f;      //Cam rotats along X axis
    public float maxVerticalAngle;          //Maximum rotation along X axis
    public float minVerticalAngle;          //Minimum rotation along Y axis
    public float smoothTime = 0.05f;        //

    float vCamRotationAngles;               //Variable to apply Vertical Rotation
    float hPlayerRotation;                  //Variable to apply Horizontal Rotation
    float currentHVelocity;                 //Smooth Horizontal velocity
    float currentVVelocity;                 //Smooth Vertical velocity
    float targetCamEulers;                  //Variable to accumulate the euler angles along X axis
    Vector3 targetCamRotation;              /*Aux variable to store the targetRotation of the 
                                            camerasParent avoiding to instatiate a new Vector3
                                            every Frame*/

    void Start()
    {
        //Hide and lock mouse cursor
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }


    void Update()
    {
        
    }

    public void handleRotation(float hInput, float vInput)
    {
        //GetRotation based on Input
        float targetPlayerRotation = hInput * hRotationSpeed * Time.deltaTime;
        targetCamEulers += vInput * vRotationSpeed * Time.deltaTime;

        //Player Rotation
        hPlayerRotation = Mathf.SmoothDamp(hPlayerRotation, targetPlayerRotation, ref currentHVelocity, smoothTime);
        transform.Rotate(0f, hPlayerRotation, 0f);

        //Cam Rotation
        targetCamEulers = Mathf.Clamp(targetCamEulers, minVerticalAngle, maxVerticalAngle);
        vCamRotationAngles = Mathf.SmoothDamp(vCamRotationAngles, targetCamEulers, ref currentVVelocity, smoothTime);
        targetCamRotation.Set(-vCamRotationAngles, 0f, 0f);
        camerasParent.transform.localEulerAngles = targetCamRotation;
    }
}
