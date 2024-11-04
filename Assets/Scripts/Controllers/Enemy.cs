using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{
    public Transform playerPos;

    private Vector3 currentVelocity;
    private float acceleration;
    private float deceleration;
    private float maxSpeedSqr;

    // From template
    public float accelerationTime = 1f;
    public float decelerationTime = 1f;
    public float maxSpeed = 7.5f;
    public float turnSpeed = 180f;
    public float warpSpeed = 3;

    // Start is called before the first frame update
    void Start()
    {
        acceleration = maxSpeed / accelerationTime;
        deceleration = maxSpeed / decelerationTime;
        maxSpeedSqr = maxSpeed * maxSpeed;
    }

    // Update is called once per frame
    void Update()
    {

        //Taken from Template
        Vector3 moveDirection = Vector3.zero;

        if (Input.GetKeyDown(KeyCode.Q) && (playerPos.position - transform.position).magnitude < 5)
        {
            moveDirection += (playerPos.position - transform.position + new Vector3(Random.Range(-1, 1), Random.Range(-1, 1), Random.Range(-1, 1))) * 60;
        }


        //Taken from Template
        if (moveDirection.sqrMagnitude > 0)
        {
            currentVelocity += Time.deltaTime * acceleration * moveDirection;
            if (currentVelocity.sqrMagnitude > maxSpeedSqr)
            {
                currentVelocity = currentVelocity.normalized * 7.5f;
            }
        }
        else
        {
            Vector3 velocityDelta = Time.deltaTime * deceleration * currentVelocity.normalized;
            if (velocityDelta.sqrMagnitude > currentVelocity.sqrMagnitude)
            {
                currentVelocity = Vector3.zero;
            }
            else
            {
                currentVelocity -= velocityDelta;
            }
        }

        transform.position += currentVelocity * Time.deltaTime;
    }

}
