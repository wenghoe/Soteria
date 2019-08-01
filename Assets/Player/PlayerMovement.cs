using System;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

[RequireComponent(typeof (ThirdPersonCharacter))]
public class PlayerMovement : MonoBehaviour
{
    ThirdPersonCharacter thirdPersonCharacter;   // A reference to the ThirdPersonCharacter on the object
    //CameraRaycaster cameraRaycaster;
    //Vector3 currentClickTarget;
        
    private void Start()
    {
        //cameraRaycaster = Camera.main.GetComponent<CameraRaycaster>();
        thirdPersonCharacter = GetComponent<ThirdPersonCharacter>();
        //currentClickTarget = transform.position;
    }

    // Fixed update is called in sync with physics
    private void FixedUpdate()
    {
        /*if (Input.GetMouseButton(0))
        {
            print("Cursor raycast hit" + cameraRaycaster.hit.collider.gameObject.name.ToString());
            currentClickTarget = cameraRaycaster.hit.point;  // So not set in default case
        }
        m_Character.Move(currentClickTarget - transform.position, false, false);
        */

        ProcessDirectMovement();
    }

    private void ProcessDirectMovement()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        // calculate camera relative direction to move:
        Vector3 cameraForward = Vector3.Scale(Camera.main.transform.forward, new Vector3(1, 0, 1)).normalized;
        Vector3 movement = v * cameraForward + h * Camera.main.transform.right;

        thirdPersonCharacter.Move(movement, false, false);
    }
}

