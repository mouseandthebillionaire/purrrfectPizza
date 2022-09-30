using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PQManager : MonoBehaviour
{
    public Sprite[] ingredientImages;
    
    
    public static PQManager S;

    void Awake()
    {
        S = this;
    }

    public void ScoreIngredients()
    {
        GlobalVariables.S.score = 0;
        transform.BroadcastMessage("ScoreQuadrant");
        GlobalVariables.S.UpdateScore();
        GlobalVariables.S.UpdateIngredients();
        Debug.Log("bang");
    }
}
