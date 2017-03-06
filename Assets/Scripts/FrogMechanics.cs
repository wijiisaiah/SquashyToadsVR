using UnityEngine;
using System.Collections;

public class FrogMechanics : MonoBehaviour {


    // Use this for initialization
    public float jumpAngle = 45;
    public float jumpStrength = 5;
    public float jumpGroundClearance = 2;
    public float jumpSpeedTolerance = 5;

    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        bool isGrounded = Physics.Raycast(transform.position, -transform.up, jumpGroundClearance);
        var speed = GetComponent<Rigidbody>().velocity.magnitude;
        bool isStationary = speed < jumpSpeedTolerance;
        if (GvrViewer.Instance.Triggered && isGrounded && isStationary)
        {
            var camera = GetComponentInChildren<Camera>();
            var cameraDirection = camera.transform.forward;
            var projectedToPlane = Vector3.ProjectOnPlane(cameraDirection, Vector3.up);
            var jumpDirection = Mathf.Deg2Rad * jumpAngle;
            var jumpVector = Vector3.Normalize(Vector3.RotateTowards(projectedToPlane, Vector3.up, jumpDirection, 0));

            GetComponent<Rigidbody>().AddForce(jumpVector*jumpStrength, ForceMode.VelocityChange);
        }	
	}

}
