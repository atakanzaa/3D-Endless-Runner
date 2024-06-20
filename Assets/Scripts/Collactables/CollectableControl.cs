using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CollectableControl : MonoBehaviour
{

    public static int coinCount;
    public TextMeshProUGUI coinText;
    public TextMeshProUGUI coinEndText;
   

    
    void Update()
    {
        coinText.text = coinCount.ToString();
        coinEndText.text = coinCount.ToString();
    }
}
