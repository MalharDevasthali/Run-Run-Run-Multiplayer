using Photon.Pun;
using TMPro;
using UnityEngine;

public class CreateAndJoinRooms : MonoBehaviourPunCallbacks
{
    [SerializeField] private TMP_InputField createLobbyInput;
    [SerializeField] private TMP_InputField joinLobbyInput;
    [SerializeField] private TMP_Text lobbyJoinFialedText;

    public void CreateRoom()
    {
        PhotonNetwork.CreateRoom(createLobbyInput.text);
    }

    public void JoinRoom()
    {
        PhotonNetwork.JoinRoom(joinLobbyInput.text);
    }
    public override void OnCreateRoomFailed(short returnCode, string message)
    {
        base.OnCreateRoomFailed(returnCode, message);
        lobbyJoinFialedText.gameObject.SetActive(true);
    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel(2);
    }
}
