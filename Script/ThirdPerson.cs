using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPerson : MonoBehaviour {
    public bool LockCurs;
    public float SensitivityMouse = 10;
    public Transform target;
    public float dTarget = 2;
    float yaw;
    float pitch;
    public Vector2 PitchIntervalle = new Vector2(-40,85);
    public float RotSmoothTime = .12f;
    Vector3 RotSmoothVelocity;
    Vector3 currentRot;
    void Start()
    {
        if (LockCurs)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }
    void LateUpdate () {
        yaw += Input.GetAxis("Mouse X") * SensitivityMouse;
        pitch -= Input.GetAxis("Mouse Y") * SensitivityMouse;

        pitch = Mathf.Clamp(pitch, PitchIntervalle.x, PitchIntervalle.y);

        currentRot = Vector3.SmoothDamp(currentRot, new Vector3(pitch, yaw), ref RotSmoothVelocity, RotSmoothTime);

        //Vector3 targetRot = new Vector3(pitch,yaw);
        transform.eulerAngles = currentRot; //targetRot;

        transform.position = target.position - transform.forward * dTarget;
        /*if (Input.GetAxisRaw("Mouse ScrollWheel") * 10 >0 && dTarget <= 12)
        {
            dTarget +=Input.GetAxisRaw("Mouse ScrollWheel") * 10;
        }
        if(Input.GetAxisRaw("Mouse ScrollWheel") * 10 < 0  && dTarget >=2)
        {
            dTarget += Input.GetAxisRaw("Mouse ScrollWheel") * 10;
        }*/
        /**pitch = Mathf.Clamp(pitch, PitchIntervalle.x, PitchIntervalle.y);

        currentRot = Vector3.SmoothDamp(currentRot, new Vector3(pitch, yaw),ref RotSmoothVelocity,RotSmoothTime);

        //Vector3 targetRot = new Vector3(pitch,yaw);
        transform.eulerAngles = currentRot; //targetRot;

        transform.position = target.position - transform.forward * dTarget;**/
	}
}
