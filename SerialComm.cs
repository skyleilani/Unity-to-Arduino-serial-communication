using UnityEngine;
using System.IO.Ports;

public class SerialCom  : MonoBehaviour
{
    static SerialPort _serialPort = new SerialPort();

    void Start()
    {
        _serialPort.Open();
        _serialPort.ReadTimeout = 1;
    }

    private void OnDisable()
    {
        _serialPort.Close();
    }
    void Update()
    {
        Debug.Log(_serialPort.ReadByte());
    }
}
