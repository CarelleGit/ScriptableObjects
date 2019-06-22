using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillTree : MonoBehaviour
{
    public Skills skills;
    PlayerInfo playerInfo;
    // Use this for initialization
    void Start()
    {
        playerInfo = GetComponent<PlayerInfo>();
        playerInfo.playerLevel += LevelUp;
    }

    // Update is called once per frame
    void Update()
    {

    }
    void LevelUp(int level)
    {
        if(level >= skills.level)
        {
            skills.unlockable = true;
        }
    }
}
