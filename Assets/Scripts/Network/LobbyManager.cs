using Photon.Pun;
using TMPro;
using UnityEngine;

public class LobbyManager : MonoBehaviourPun
{

    [SerializeField] TMPro.TMP_InputField NewRoomName;
    [SerializeField] GameObject RoomsContainer;

    public void CreateRoom()
    {
        this.photonView.RPC("SaveRoomCreated", RpcTarget.AllBuffered, NewRoomName.text);
        //PhotonNetwork.CreateRoom(NewRoomName.text);
    }
    public void JoinRoom()
    {
        PhotonNetwork.JoinRoom("");
    }

    [PunRPC]
    void SaveRoomCreated(string RoomName)
    {
        GameObject RoomCreatedButton = PhotonNetwork.Instantiate("Button_RoomCreatedName", transform.position, Quaternion.identity);
        RoomCreatedButton.transform.SetParent(GameObject.FindGameObjectWithTag("RoomsAvaliableConteiner").transform);
        RoomCreatedButton.GetComponentInChildren<TMPro.TMP_Text>().text = RoomName;
    }
}
