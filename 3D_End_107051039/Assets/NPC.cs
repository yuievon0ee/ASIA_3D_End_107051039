
using UnityEngine;

[CreateAssetMenu(fileName ="NPC資料",menuName ="Yui/NPC資料")]
public class NPC : ScriptableObject
{
    [Header("蝙蝠對話1"),TextArea(1,5)]
    public string dialougA;
    [Header("蝙蝠對話2"), TextArea(1, 5)]
    public string dialougB;
    [Header("蝙蝠對話3"), TextArea(1, 5)]
    public string dialougC;
    [Header("任務項目需求數量")]
    public int count;
    [Header("已取得項目數量")]
    public int countCurrent;

}
