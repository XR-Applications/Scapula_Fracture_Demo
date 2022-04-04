using TMPro;
using UnityEngine;

public class Playground : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI debugText;

    public void DisplayDebug(string debugMsg)
    {
        debugText.text = debugMsg;
    }
}
