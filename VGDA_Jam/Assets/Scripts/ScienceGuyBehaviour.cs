using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScienceGuyBehaviour : MonoBehaviour {

    public float movementForce;
    public float turningSpeed;
    public float maxSpeed;
    public float drag;
    private Rigidbody2D scienceGuyRB;
    private Vector2 movementX;
    private Vector2 movementY;
    private float dragX;
    private float dragY;
    private Vector2 vel;

    private void Start() {
        scienceGuyRB = GetComponent<Rigidbody2D>();
        dragX = 0;
        dragY = 0;
    }

    private void FixedUpdate() {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        vel = scienceGuyRB.velocity;
        movementX.x = moveHorizontal;
        movementY.y = moveVertical;
        if(Mathf.Abs(scienceGuyRB.velocity.x) < maxSpeed) {
            scienceGuyRB.AddForce(movementForce * movementX);
        }
        if(Mathf.Abs(scienceGuyRB.velocity.y) < maxSpeed) {
            scienceGuyRB.AddForce(movementForce * movementY);
        }
        vel.x = vel.x * dragX;
        vel.y = vel.y * dragY;
        scienceGuyRB.velocity = vel;
    }

    private void Update() {

        if (Input.GetButtonDown("Horizontal")) {
            vel.x = vel.x / turningSpeed;
        }
        if (Input.GetButtonDown("Vertical")) {
            vel.y = vel.y / turningSpeed;
        }

        if (Input.GetAxis("Horizontal") != 0) {
            dragX = drag;
        }
        else if(Input.GetAxis("Horizontal") == 0) {
            dragX = 0;
        }
        if (Input.GetAxis("Vertical") != 0) {
            dragY = drag;
        }
        else if (Input.GetAxis("Vertical") == 0) {
            dragY = 0;
        }
    }

    private void OnCollisionEnter(Collision collision) {
        
    }
}