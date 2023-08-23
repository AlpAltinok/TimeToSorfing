using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTakip : MonoBehaviour
{
    public Transform player;
    private Vector3 offset;
    private Vector3 newPosition;
    public float lerpValue;
    void Start()
    {
        offset = transform.position - player.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        SetCamera();
    }
    void SetCamera()
    {
        newPosition = Vector3.Lerp(transform.position, new Vector3(0f, player.position.y, player.position.z)+offset,lerpValue*Time.deltaTime);
        transform.position = newPosition;
    }
}
