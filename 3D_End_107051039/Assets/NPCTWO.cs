using UnityEngine.UI;
using UnityEngine;
using System.Collections;

public class NPCTWO : MonoBehaviour
{
    [Header("NPC 資料")]
    public NPC data;
    [Header("畫布")]
    public GameObject dialog;
    [Header("內容")]
    public Text textContent;
    [Header("對話間隔")]
    public float interval = 0.2f;

    public bool playerInArea;

    
    public enum NPCState
    {
        FirstDialog,Missioning,Finish
    }
    [Header("NPC狀態")]
    public NPCState state = NPCState.FirstDialog;

    private void OnTriggerEnter(Collider other)
    {
        if(other.name== "ThirdPerson")
        {
            playerInArea = true;
            StartCoroutine(Dialog());
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.name== "ThirdPerson")
        {
            playerInArea = false;
            StopDialog();
        }
    }

    private void StopDialog()
    {
        dialog.SetActive(false);
        StopAllCoroutines();
    }

    private IEnumerator Dialog()
    {
        dialog.SetActive(true);
        textContent.text = "";
        string dialogString = data.dialougB;

        switch(state)
        {
            case NPCState.FirstDialog:
                dialogString = data.dialougA;
                break;
            case NPCState.Missioning:
                dialogString = data.dialougB;
                break;
            case NPCState.Finish:
                dialogString = data.dialougC;
                break;

        }

        for(int i=0;i<dialogString.Length;i++)
        {
            textContent.text += dialogString[i] + "";
            yield return new WaitForSeconds(interval);
        }
    }
}
