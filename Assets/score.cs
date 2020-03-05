using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Text mtext;
    public static int scorer;
    public int tempScore=0;
    public void ScoreUpdate(int scor){
        tempScore = tempScore+scor;
        scorer = tempScore;
        mtext.text = scorer.ToString("0");
    }
}
