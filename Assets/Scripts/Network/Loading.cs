using Photon.Pun;
using UnityEngine;

public class Loading : MonoBehaviourPunCallbacks
{
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby();
        PhotonNetwork.LoadLevel("Lobby");
    }
}
