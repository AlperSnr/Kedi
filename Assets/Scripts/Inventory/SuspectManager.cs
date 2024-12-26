using System.Collections.Generic;
using UnityEngine;

public class SuspectManager : MonoBehaviour
{
    public List<GameObject> suspectUIs;
    public List<int> nailSuspects;
    public List<int> featherSuspects;

    public void CollectItem(string itemName)
    {


        if (itemName == "T�rnak")
        {
            EliminateSuspects(nailSuspects); 
        }
        else if (itemName == "T�y")
        {
            EliminateSuspects(featherSuspects); 
        }
    }

    private void EliminateSuspects(List<int> suspectIndices)
    {
        foreach (int index in suspectIndices)
        {
            if (index >= 0 && index < suspectUIs.Count) 
            {
                Destroy(suspectUIs[index]); 
            }
        }
    }
}
