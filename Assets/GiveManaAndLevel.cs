using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveManaAndLevel : MonoBehaviour
{
    public PlayerInfo playerInfo;
    KeyCode keys;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    { 
        if(Input.GetKey(KeyCode.L))
        {
            playerInfo.Exp += 10;
        }
        if(Input.GetKey(KeyCode.M))
        {
            playerInfo.manaAmount += 100;
        }
    }
}
