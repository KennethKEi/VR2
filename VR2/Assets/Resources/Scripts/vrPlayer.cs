using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vrPlayer : MonoBehaviour
{
    private PhotonView PV;
    public Camera _camera;
    public AudioListener _AL;


    // Start is called before the first frame update
    void Start()
    {
        PV = GetComponent<PhotonView>();    
    }

    // Update is called once per frame
    void Update()
    {
        if(!PV.IsMine)
        {
            Destroy(_camera);
            Destroy(_AL);
            
        }
    }
}
