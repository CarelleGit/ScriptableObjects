using System.Collections;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Skill", menuName = "Create a Skill",order = 1)]
public class Skills : ScriptableObject
{
    public string skillName;
    public Sprite skillIcon;
    public int manacosts;
    public Button skillButton; 
    [Header("Requirements")]
    public int level;
    public string[] SkillRequired;
    [Header("Skill State Check")]
    public bool unlockable = false;
    public bool unlcoked = false;
}
