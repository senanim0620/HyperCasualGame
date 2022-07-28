using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class FollowCam : MonoBehaviour
{
    public PlayerType playerType;
    private CinemachineVirtualCamera _cinema;

    // Start is called before the first frame update
    void Start()
    {
      // var _cinema = GetComponent<CinemachineVirtualCamera>();

       // _cinema.Follow = playerType._player[playerType.character.character_type].transform;

      //  _cinema.LookAt = playerType._player[playerType.character.character_type].transform;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
