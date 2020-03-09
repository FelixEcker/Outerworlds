/****************************************/
/*Outerworlds Player Movement Controller*/
/*Author: Felix Eckert                  */
/****************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Speed setting variables
    public float maxSpeed;
    //////////////////////////

    // Objects to be moved
    public Rigidbody2D player; // Player's Rigidbody
    public Camera camera;      // Camera
    //////////////////////

    public Vector3 cameraOffset; // The cameras offset relative to the player

    void FixedUpdate() {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical   = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        player.velocity = movement * maxSpeed;

        Vector3 newCameraPosition = new Vector3(player.position.x + cameraOffset.x, player.position.y + cameraOffset.y, cameraOffset.z);
        camera.transform.position = newCameraPosition;
    }
}
