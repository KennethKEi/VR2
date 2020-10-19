using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetworkController : MonoBehaviourPunCallbacks
{

    [SerializeField]
    bool connectOnStart;

    [SerializeField]
    private int gameVersion;

    private void Start()
    {
        if (connectOnStart)
        {
            Connect();
        }
    }

    // Start is called before the first frame update
    public void Connect()
    {
        PhotonNetwork.GameVersion = gameVersion.ToString();
        PhotonNetwork.ConnectUsingSettings(); //Connects to Photon master servers
        //Other ways to make a connection can be found here: https://doc-api.photonengine.com/en/pun/v2/class_photon_1_1_pun_1_1_photon_network.html
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("We are now connected to the " + PhotonNetwork.CloudRegion + " server!");
    }
}
