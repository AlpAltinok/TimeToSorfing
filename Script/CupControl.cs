using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CupControl : MonoBehaviour
{
    private Vector3 direction = Vector3.back;
    [SerializeField] private Stackleme st;
    RaycastHit hit;
    //BoxcastCommand hitle; // boxla güncelleyeceðiz
    bool isStack;
    void Start()
    {
        st = GameObject.FindObjectOfType<Stackleme>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        CubeRaycast();
    }
    private void CubeRaycast()
    {
       Vector3 halfExtents = new Vector3(0.5f, 0.5f, 0.5f); // Set the half extents of the box (cube)

        if (Physics.BoxCast(transform.position, halfExtents, direction, out hit, transform.rotation, 1.8f))
        {
            if (!isStack)
            {
                isStack = true;
                st.Stack(gameObject);
                SetDirection();
            }
            if (hit.transform.name == "ObstacleCube")
            {
                st.DecreaseBlock(gameObject);
            }
        }/*
         if (Physics.Raycast(transform.position,direction, out hit, 1.8f)){ 
             if (!isStack)
             {
                 isStack = true;
                 st.Stack(gameObject);
                 SetDirection(); 
             }
             if (hit.transform.name == "ObstcaleCube")
             {
                 st.DecreaseBlock(gameObject);
             }
         }*/

    }
    void SetDirection()
    {
        direction = Vector3.forward;
    }
}
