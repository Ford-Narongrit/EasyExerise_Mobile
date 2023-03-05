using System;
using UnityEngine;
using TMPro;

public class TestScene : MonoBehaviour
{
    [SerializeField] private Animator startSceneAnimator;

    [SerializeField] TMP_Text gyroX;
    [SerializeField] TMP_Text gyroY;
    [SerializeField] TMP_Text gyroZ;

    [SerializeField] TMP_Text accelX;
    [SerializeField] TMP_Text accelY;
    [SerializeField] TMP_Text accelZ;
    [SerializeField] TMP_Text accelText;

    public void OnclickTest()
    {
        startSceneAnimator.SetTrigger("test");
    }

    public void ping()
    {
        Debug.Log("log click ping.");
        try
        {
            Client.Instance.SendToServer(new NetPing());
        }
        catch (Exception e)
        {
            Debug.Log(e.ToString());
        }
    }

    private void Start()
    {
        GyroManager.Instance.EnableGyro();
        AccelerationManager.Instance.EnableAccel();
    }

    private void Update()
    {
        gyroX.text = "Gyro X: " + GyroManager.Instance.GetGyroRotation().x;
        gyroY.text = "Gyro Y: " + GyroManager.Instance.GetGyroRotation().y;
        gyroZ.text = "Gyro Z: " + GyroManager.Instance.GetGyroRotation().z;
        // Debug.Log(GyroManager.Instance.GetGyroRotation());

        accelX.text = "Accel X: " + AccelerationManager.Instance.GetAcceleration().x;
        accelY.text = "Accel Y: " + AccelerationManager.Instance.GetAcceleration().y;
        accelZ.text = "Accel Z: " + AccelerationManager.Instance.GetAcceleration().z;
        accelText.text = "Accel: " + AccelerationManager.Instance.GetAcceleration().sqrMagnitude;
    }
}
