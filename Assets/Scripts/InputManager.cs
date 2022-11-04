using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputManager: MonoBehaviour
{
    #region Fields

    // serialize fields for input field's text component
    [SerializeField]
    Text createTimeText;
    [SerializeField]
    Text cubeSpeedText;
    [SerializeField]
    Text deathDistanceText;

    // support for same properties
    static float createTime = 0;
    static float cubeSpeed = 0;
    static float deathDistance = 0;

    #endregion

    #region Properties

    /// <summary>
    /// Set the time of creating cube
    /// </summary>
    public static float CreateTime
    {
        get { return createTime; }
    }

    /// <summary>
    /// Set the cube's speed
    /// </summary>
    public static float CubeSpeed
    {
        get { return cubeSpeed; }
    }

    /// <summary>
    /// Set the distance of cube destruction
    /// </summary>
    public static float DeathDistance
    {
        get { return deathDistance; }
    }

    #endregion

    #region Methods

    /// <summary>
    /// Set the time of creating cube when user submit value into input field
    /// </summary>
    public void CreateTimeOnSubmitHandler()
    {
        string createTimeString = createTimeText.text;
        try
        {
            createTime = float.Parse(createTimeString);
        }
        catch (System.Exception)
        {
        }        
    }

    /// <summary>
    /// Set the cube speed when user submit value into input field
    /// </summary>
    public void CubeSpeedOnSubmitHandler()
    {
        string cubeSpeedString = cubeSpeedText.text;
        try
        {
            cubeSpeed = float.Parse(cubeSpeedString);
        }
        catch (System.Exception)
        {
        }           
    }

    /// <summary>
    /// Set the distance of cube destruction when user submit value into input field
    /// </summary>
    public void DeathDistanceOnSubmitHandler()
    {
        string deathDistanceString = deathDistanceText.text;
        try
        {
            deathDistance = float.Parse(deathDistanceString);
        } 
        catch (System.Exception)
        { 
        }
    }

    #endregion
}
