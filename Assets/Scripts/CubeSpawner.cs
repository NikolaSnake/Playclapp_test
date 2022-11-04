using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    #region Fields

    [SerializeField]
    GameObject prefabCube;

    // cube start spawn location
    Vector3 spawnLoc = new Vector3(-9, 2, 0);

    // timer support for creating each cube
    Timer timer;

    #endregion

    #region Methods

    // Start is called before the first frame update
    void Start()
    {
        // add timer component to main camera
        timer = gameObject.AddComponent<Timer>();
    }

    // Update is called once per frame
    void Update()
    {
        // create cube if timer is finished and rerun it
        if (timer.Finished)
        {
            GameObject cube = Instantiate<GameObject>(prefabCube, spawnLoc, Quaternion.identity);
            timer.Run();
        }
    }

    /// <summary>
    /// Set timer duration.
    /// Start timer for creating each cube when user submit value into input field
    /// </summary>
    public void CreateTimeOnSubmitHandler()
    {
        timer.Stop();
        timer.Duration = InputManager.CreateTime;
        timer.Run();
    }

    #endregion
}
