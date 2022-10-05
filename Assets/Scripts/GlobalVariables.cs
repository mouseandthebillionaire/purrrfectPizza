using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalVariables : MonoBehaviour
{
    public string[] ingredientTypes     = new string[] {"M", "O", "P", "R", "S"};
    public int[]    ingredientNums      = new int[] {8, 4, 4, 4, 4};
    public int      ingredientsPlayed   = 0; // this should be done dynamically, eventually
    public Text[]   ingredientNumText;
    public int      numQuadrants = 35;
    // these are the relational maths numbers for figuring out the surrounding ingredients
    public int[]    directionalNums = new int[] {-7, -6, -5, -1, 1, 5, 6, 7};

    public int   score;
    public Text scoreText;

    public static GlobalVariables S;
    
    // Start is called before the first frame update
    void Awake()
    {
        S = this;
    }

    void Start()
    {
        score = 0;
        UpdateScore();
        UpdateIngredients();
    }

    public void UpdateScore()
    {
        scoreText.text = "Score:\n" + score.ToString();
        float scoreHealth = (24 - GlobalVariables.S.ingredientsPlayed) + score;
        FMODUnity.RuntimeManager.StudioSystem.setParameterByName("Score Health", scoreHealth);
        FMODUnity.RuntimeManager.StudioSystem.setParameterByName("Score", score);
        Debug.Log(scoreHealth);
    }

    public void UpdateIngredients()
    {
        for (int i = 0; i < ingredientTypes.Length; i++)
        {
            ingredientNumText[i].text = ingredientNums[i].ToString();
        }
    }
}
