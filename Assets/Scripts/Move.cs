using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float moveSpeed = 10.0f;

    private string horizonName = "Horizon";
    private string verticalName = "Vertical";

    private Vector3 forwardMoveVector = new Vector3(0, 0, 1);
    private Vector3 rightMoveVector = new Vector3(1, 0, 0);

    // Start is called before the first frame update
    void Start()
    {
        var character = GetComponent<Character>();
        // initInputNames;
        horizonName += character.controllerID;
        verticalName += character.controllerID;

        forwardMoveVector = Camera.main.transform.forward;
        forwardMoveVector.y = 0;
        forwardMoveVector.Normalize();

        rightMoveVector = Quaternion.Euler(new Vector3(0, 90, 0)) * forwardMoveVector;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxis(horizonName) != 0 || Input.GetAxis(verticalName) != 0) {
            var moveVector  = Input.GetAxis(horizonName) * rightMoveVector + Input.GetAxis(verticalName) * forwardMoveVector;
            transform.position += moveVector * moveSpeed * Time.deltaTime;
        }
    }
}
