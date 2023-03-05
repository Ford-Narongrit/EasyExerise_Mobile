using UnityEngine;

public class AccelerationManager : MonoBehaviour
{
    #region Singleton implementation
    public static AccelerationManager Instance { set; get; }
    private void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(this.gameObject);
    }
    #endregion

    [Header("Logic")]
    private Vector3 acceleration = Vector3.zero;
    private bool AccelActive;

    public void EnableAccel()
    {
        AccelActive = true;

        // if (AccelActive)
        //     return;

        // if (SystemInfo.supportsAccelerometer)
        // {
        //     AccelActive = true;
        // }
        // else
        // {
        //     AccelActive = false;
        //     Debug.LogError("Acceler is not supported on this device.");
        // }
    }

    private void Update()
    {
        Debug.Log("Acceler is running :" + AccelActive);
        if (AccelActive)
        {
            acceleration = Input.acceleration;
            Debug.Log("acceleration vector is : " + acceleration);
        }
    }

    public Vector3 GetAcceleration()
    {
        return acceleration;
    }
}
