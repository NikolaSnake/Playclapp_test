using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    #region Fields

    // set the cube speed and distance of destruction
    float speedFactor = InputManager.CubeSpeed;
    float distance = InputManager.DeathDistance;

    // point of spawn location
    float startPoint;

    // save cube rigidbody component
    Rigidbody rigidbody;

    #endregion
    
    #region Methods

    // Start is called before the first frame update
    void Start()
    {
        // get cube rigidbody component
        rigidbody = gameObject.GetComponent<Rigidbody>();

        // set the point of spawn location
        startPoint = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        // update cube speed
        rigidbody.velocity = new Vector3(1, 0, 0) * speedFactor;

        // destroy cube if it out of allowable distance 
        if (transform.position.x - startPoint >= distance)
        {
            Destroy(gameObject);
        }
    }

    #endregion
}
