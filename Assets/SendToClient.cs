using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net;
using System.Net.Sockets;
using System.Text;

public class SendToClient : MonoBehaviour
{
    private UdpClient udpClient;
    public string ipAddress = "127.0.0.1"; // Receiver IP
    public int port = 25002;              // Receiver Port

    void Start()
    {
        try
        {
            udpClient = new UdpClient();
            Debug.Log($"UDP client initialized. Sending to {ipAddress}:{port}");
        }
        catch (System.Exception ex)
        {
            Debug.LogError($"Error initializing UDP client: {ex.Message}");
        }
    }

    public void SendData(string message)
    {
        try
        {
            if (udpClient == null)
            {
                Debug.LogWarning("UDP client is not initialized!");
                return;
            }

            // Convert the message to bytes
            byte[] data = Encoding.UTF8.GetBytes(message);

            // Send the data
            udpClient.Send(data, data.Length, ipAddress, port);
            Debug.Log($"Sent: {message}");
        }
        catch (System.Exception ex)
        {
            Debug.LogError($"Error sending data: {ex.Message}");
        }
    }

    void OnApplicationQuit()
    {
        SendData("q");
        Cleanup();
    }

    void OnDestroy()
    {
        SendData("q");
        Cleanup();
    }

    void Cleanup()
    {
        if (udpClient != null)
        {
            udpClient.Close();
            udpClient = null;
            Debug.Log("UDP client closed.");
        }
    }
}
