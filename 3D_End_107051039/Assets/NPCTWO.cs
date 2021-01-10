using UnityEngine.UI;
using UnityEngine;

public class NPCTWO : MonoBehaviour
{
    [Header("NPC 資料")]
    public NPC data;
    [Header("畫布")]
    public GameObject dialog;
    [Header("內容")]
    public Text textContent;

    public bool playerInArea;

    private void OnTriggerEnter(Collider other)
    {
        if(other.name== "ThirdPerson")
        {
            playerInArea = true;
            Dialog();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.name== "ThirdPerson")
        {
            playerInArea = false;
        }
    }

    private void Dialog()
    {
        for(int i=0;i<data.dialougA.Length;i++)
        {
            print(data.dialougA[i]);
        }
    }
}
