using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshWander : MonoBehaviour
{
    public float moveSpeed = 3.0f;
    public float rotSpeed = 100f;
    public float powerMultiplier = 5.0f;

    private bool isWandering = false;
    private bool isRotatingLeft = false;
    private bool isRotatingRight = false;
    private bool isWalking = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(!isWandering)
        {
            StartCoroutine(Wander());
        }
        if(isRotatingRight)
        {
            transform.Rotate(transform.up * Time.deltaTime * rotSpeed * powerMultiplier);
        }
        if (isRotatingLeft)
        {
            transform.Rotate(transform.up * Time.deltaTime * -rotSpeed * powerMultiplier);
        }
        if(isWalking)
        {
            transform.position += transform.forward * moveSpeed * Time.deltaTime * powerMultiplier;
        }
    }

    IEnumerator Wander()
    {
        int rotTime = Random.Range(1, 3);
        int rotateWait = 0;
        int rotateLorR = Random.Range(0, 3);
        int walkWait = 0;
        int walkTime = Random.Range(1, 5);

        isWandering = true;

        yield return new WaitForSeconds(walkWait);
        isWalking = true;
        yield return new WaitForSeconds(walkTime * powerMultiplier);
        isWalking = false;
        yield return new WaitForSeconds(rotateWait);

        if(rotateLorR == 1)
        {
            isRotatingRight = true;
            yield return new WaitForSeconds(rotTime * powerMultiplier);
            isRotatingRight = false;
        }

        if (rotateLorR == 2)
        {
            isRotatingLeft = true;
            yield return new WaitForSeconds(rotTime * powerMultiplier);
            isRotatingLeft = false;
        }

        isWandering = false;

    }
}
