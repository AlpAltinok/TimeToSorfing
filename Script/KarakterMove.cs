using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KarakterMove : MonoBehaviour
{
    [SerializeField] private KarakterControl kC;
    [SerializeField] private float forwardMove;
    private float horizontalMove=140f;
    private float horizontalMoveLimit=6.3f;
    private float newPositionX;
    void Start()
    {
        
    }

    
    void FixedUpdate()
    {
        ForwardMove();
        HorizontalMove();
    }

    private void ForwardMove()
    {
        transform.Translate(Vector3.down * forwardMove * Time.fixedDeltaTime);
    }
    void HorizontalMove()
    {
        newPositionX = transform.position.x + kC.HorizontalValue * horizontalMove * Time.fixedDeltaTime;
        newPositionX = Mathf.Clamp(newPositionX, -horizontalMoveLimit, horizontalMoveLimit);
        transform.position = new Vector3(newPositionX, transform.position.y, transform.position.z);
    }


}
