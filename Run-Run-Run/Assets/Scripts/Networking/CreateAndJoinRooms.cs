using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Photon.Pun;

public class CreateAndJoinRooms : MonoBehaviourPunCallbacks
{
    public TMP_InputField createLobbyInput;
    public TMP_InputField joinLobbyInput;

    public void CreateRoom()
    {
        PhotonNetwork.CreateRoom(createLobbyInput.text);
    }

    public void JoinRoom()
    {
        PhotonNetwork.JoinRoom(joinLobbyInput.text);
    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel(2);
    }
}
