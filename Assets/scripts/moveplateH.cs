using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveplateH : MonoBehaviour
{
    [SerializeField]
    public float speed = 1f;
    public float up = 2f;
    public float down = 0.1f;
    private Vector3 targetPosition = default;
    private Vector3 targetPositionDown = default;
    

    private bool touchingPlayer = false;

    private void Start()
    {
        targetPosition = new Vector3(
            transform.position.x,
            transform.position.y + up,
            transform.position.z); 

        targetPositionDown = new Vector3(
            transform.position.x,
            transform.position.y + down,
            transform.position.z);
        
    }

    private void FixedUpdate()
    {
        if (touchingPlayer)
        {
            transform.position = Vector3.MoveTowards(
                transform.position,
                targetPosition,
                speed * Time.fixedDeltaTime);
        }

        if (touchingPlayer == false)
        {
            transform.position = Vector3.MoveTowards(
                transform.position,
                targetPositionDown,
                speed * Time.fixedDeltaTime);
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
            touchingPlayer = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
            touchingPlayer = false;
    }
}
