using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LastScore : MonoBehaviour
{
    public Text myText;
    public static int finaleScore;
    // Start is called before the first frame update
    void Start()
    {
        finaleScore = score.scorer;
        myText.text = "Final Score\n\n"+finaleScore.ToString("0");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
