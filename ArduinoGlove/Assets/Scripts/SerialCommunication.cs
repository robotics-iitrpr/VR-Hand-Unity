using UnityEngine;
using System.IO.Ports;
using System;
using System.Collections;
using System.Threading;
using UnityEngine.UIElements;
using System.Globalization;

public class SerialCommunication : MonoBehaviour
{

    [SerializeField]
    private HandController hand;

    [SerializeField]
    private FingerController thumb1, thumb2, thumb3;

    [SerializeField]
    private FingerController index1, index2, index3;

    [SerializeField]
    private FingerController middle1, middle2, middle3;

    [SerializeField]
    private FingerController ring1, ring2, ring3;

    [SerializeField]
    private FingerController pinky1, pinky2, pinky3;

    private static SerialPort port = new SerialPort("COM10", 9600);
    private static string incomingMsg = "";

    void Start()
    {
        port.Open();
    }

    // Update is called once per frame
    void Update()
    {
        if (port.IsOpen)
        {
            incomingMsg = port.ReadTo(";");
            if (incomingMsg != "")
            {
                // Spliting data for Index, Middle and Ring
                string[] flexTypeData = incomingMsg.Split("|");
                // Index Finger
                index1.Rotate(float.Parse(flexTypeData[0], CultureInfo.InvariantCulture.NumberFormat), 0, 0);
                index2.Rotate(float.Parse(flexTypeData[0], CultureInfo.InvariantCulture.NumberFormat), 0, 0);
                index3.Rotate(float.Parse(flexTypeData[0], CultureInfo.InvariantCulture.NumberFormat), 0, 0);
                // Middle Finger
                middle1.Rotate(float.Parse(flexTypeData[1], CultureInfo.InvariantCulture.NumberFormat), 0, 0);
                middle2.Rotate(float.Parse(flexTypeData[1], CultureInfo.InvariantCulture.NumberFormat), 0, 0);
                middle3.Rotate(float.Parse(flexTypeData[1], CultureInfo.InvariantCulture.NumberFormat), 0, 0);
                // Ring Finger
                ring1.Rotate(float.Parse(flexTypeData[2], CultureInfo.InvariantCulture.NumberFormat), 0, 0);
                ring2.Rotate(float.Parse(flexTypeData[2], CultureInfo.InvariantCulture.NumberFormat), 0, 0);
                ring3.Rotate(float.Parse(flexTypeData[2], CultureInfo.InvariantCulture.NumberFormat), 0, 0);
                // Ring Finger
                thumb1.Rotate(float.Parse(flexTypeData[3], CultureInfo.InvariantCulture.NumberFormat), 0, 0);
                thumb2.Rotate(float.Parse(flexTypeData[3], CultureInfo.InvariantCulture.NumberFormat), 0, 0);
                thumb3.Rotate(float.Parse(flexTypeData[3], CultureInfo.InvariantCulture.NumberFormat), 0, 0);
                // Pinky Finger
                pinky1.Rotate(float.Parse(flexTypeData[4], CultureInfo.InvariantCulture.NumberFormat), 0, 0);
                pinky2.Rotate(float.Parse(flexTypeData[4], CultureInfo.InvariantCulture.NumberFormat), 0, 0);
                pinky3.Rotate(float.Parse(flexTypeData[4], CultureInfo.InvariantCulture.NumberFormat), 0, 0);
            }
        }
    }
}