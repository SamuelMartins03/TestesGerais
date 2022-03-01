using Photon.Pun;
using UnityEngine;

public class LobbyManager : MonoBehaviourPunCallbacks
{

    [SerializeField] string RoomName;

    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby();
    }

    public void CreateRoom()
    {
        PhotonNetwork.CreateRoom("");
    }
    public void JoinRoom()
    {
        PhotonNetwork.JoinRoom("");
    }


}
