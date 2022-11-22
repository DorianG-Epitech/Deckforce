using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisconnectButtonTest : MonoBehaviour
{
    public Button connectButton;
    public Button disconnectButton;
    public Button sendDataButton;
    public Button stopServer;

    public void OnDisconnect()
    {
        GameServer.instance.Disconnect(DisconnectedFromServer);
    }

    private void DisconnectedFromServer()
    {
        connectButton.interactable = true;
        disconnectButton.interactable = false;
        sendDataButton.interactable = false;
        stopServer.interactable = false;
    }
}
