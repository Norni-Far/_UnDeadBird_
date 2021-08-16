using UnityEngine;
using UnityEngine.UI;

public class S_Statistics : MonoBehaviour
{

    public Text StatText;

    int Rssult;  

    public void SetResult()
    {
        Rssult++;
        StatText.text = (Rssult).ToString();
    }



}
