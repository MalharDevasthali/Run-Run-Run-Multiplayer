using Photon.Pun;
using TMPro;
using UnityEngine;

public class CreateAndJoinRooms : MonoBehaviourPunCallbacks
{
    [SerializeField] private TMP_InputField createLobbyInput;
    [SerializeField] private TMP_InputField joinLobbyInput;
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
