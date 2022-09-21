using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PQ : MonoBehaviour
{
    public  string ingredientType;
    public bool   acceptingIngredient;

    private SpriteRenderer sr;
    
    // PQ (Pizza Quadrent) is the individual areas in which topping can be placed
    // Todo:
    //     They need to be able to get information from other PQs specifically
    //     a) who is next to them (separate function for diagonal?)
    //     b) who is far from them
    //     c) how many Xs are there near and/or far from them?
    //     d) how far are they from the edge of the pie?
    //     e) future: who is in the same slice as them?

    // Start is called before the first frame update
    void Start()
    {
        ingredientType = "";
        sr = GetComponent<SpriteRenderer>();
        if (this.name == "0" || this.name == "5" || this.name == "30" || this.name == "35")
        {
            sr.enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OnMouseOver()
    {
        if (ingredientType == "" || acceptingIngredient)
        {
            sr.color = new Color(sr.color.r, sr.color.g, sr.color.b, 0.5f);
            if (Input.GetKeyDown(KeyCode.M) && GlobalVariables.S.ingredientNums[0] > 0)
            {
                ingredientType = "M";
                acceptingIngredient = false;
                sr.sprite = PQManager.S.ingredientImages[0];
                GlobalVariables.S.ingredientNums[0] -= 1;
                PQManager.S.ScoreIngredients();


            }

            if (Input.GetKeyDown(KeyCode.O) && GlobalVariables.S.ingredientNums[1] > 0)
            {
                ingredientType = "O";
                acceptingIngredient = false;
                sr.sprite = PQManager.S.ingredientImages[1];
                GlobalVariables.S.ingredientNums[1] -= 1;
                PQManager.S.ScoreIngredients();

            }

            if (Input.GetKeyDown(KeyCode.P) && GlobalVariables.S.ingredientNums[2] > 0)
            {
                ingredientType = "P";
                acceptingIngredient = false;
                sr.sprite = PQManager.S.ingredientImages[2];
                GlobalVariables.S.ingredientNums[2] -= 1;
                PQManager.S.ScoreIngredients();

            }

            if (Input.GetKeyDown(KeyCode.R) && GlobalVariables.S.ingredientNums[3] > 0)
            {
                ingredientType = "R";
                acceptingIngredient = false;
                sr.sprite = PQManager.S.ingredientImages[3];
                GlobalVariables.S.ingredientNums[3] -= 1;
                PQManager.S.ScoreIngredients();

            }

            if (Input.GetKeyDown(KeyCode.S) && GlobalVariables.S.ingredientNums[4] > 0)
            {
                ingredientType = "S";
                acceptingIngredient = false;
                sr.sprite = PQManager.S.ingredientImages[4];
                GlobalVariables.S.ingredientNums[4] -= 1;
                PQManager.S.ScoreIngredients();

            }

        }
        else sr.color = new Color(sr.color.r, sr.color.g, sr.color.b, 1f);
    }

    public void OnMouseExit()
    {
        if (ingredientType == "" || acceptingIngredient) sr.color = new Color(sr.color.r, sr.color.g, sr.color.b, 1f);
    }

    public void ScoreQuadrant()
    {
        // check what kind of ingredient it is
        for (int i = 0; i < GlobalVariables.S.ingredientTypes.Length; i++)
        {
            if (ingredientType == GlobalVariables.S.ingredientTypes[i])
            {
                Debug.Log("It's a " + GlobalVariables.S.ingredientTypes[i].ToString());
                if (ingredientType == "M") Mushroom();
                if (ingredientType == "O") Olive();
                if (ingredientType == "P") Pineapple();
                if (ingredientType == "R") Roni();
                if (ingredientType == "S") Sausage();
            }
        }
    }
    
    // Special Functions for Each Ingredient (for ease of this iteration)
    private void Mushroom()
    {
        for (int i = 0; i < GlobalVariables.S.directionalNums.Length; i++)
        {
            int PQLoc = int.Parse(this.transform.name) + GlobalVariables.S.directionalNums[i];
            if (PQLoc >= 0 && PQLoc <= 35)
            {
                GameObject other = GameObject.Find(PQLoc.ToString());
                if (other.GetComponent<PQ>().ingredientType == "M")
                {
                    GlobalVariables.S.score -= 1;
                }
            }
        }
    }
    
    private void Olive()
    {
        for (int i = 0; i < GlobalVariables.S.directionalNums.Length; i++)
        {
            int PQLoc = int.Parse(this.transform.name) + GlobalVariables.S.directionalNums[i];
            if (PQLoc >= 0 && PQLoc <= 35)
            {
                GameObject other = GameObject.Find(PQLoc.ToString());
                if (other.GetComponent<PQ>().ingredientType == "O") GlobalVariables.S.score += 1;
            }
        }
    }
    
    private void Pineapple()
    {
        for (int i = 0; i < GlobalVariables.S.directionalNums.Length; i++)
        {
            int PQLoc = int.Parse(this.transform.name) + GlobalVariables.S.directionalNums[i];
            if (PQLoc >= 0 && PQLoc <= 35)
            {
                GameObject other = GameObject.Find(PQLoc.ToString());
                if (other.GetComponent<PQ>().ingredientType != "")
                {
                    if (other.GetComponent<PQ>().ingredientType == "S" ||
                        other.GetComponent<PQ>().ingredientType == "R")
                    {
                        GlobalVariables.S.score += 2;
                    }
                    else
                    {
                        GlobalVariables.S.score -= 1;
                    }
                }
                
            }
        }
    }
    
    private void Roni()
    {
        for (int i = 0; i < GlobalVariables.S.directionalNums.Length; i++)
        {
            int PQLoc = int.Parse(this.transform.name) + GlobalVariables.S.directionalNums[i];
            if (PQLoc >= 0 && PQLoc <= 35)
            {
                GameObject other = GameObject.Find(PQLoc.ToString());
                if (other.GetComponent<PQ>().ingredientType == "S")
                {
                    GlobalVariables.S.score += 1;
                }
            }
        }
    }
    
    private void Sausage()
    {
        // This is a very stupid way of doing this. Fix in the future if you want dynamic boards
        if(
            this.name == "1" ||
            this.name == "2" ||
            this.name == "3" ||
            this.name == "4" ||
            this.name == "6" ||
            this.name == "11" ||
            this.name == "12" ||
            this.name == "17" ||
            this.name == "18" ||
            this.name == "23" ||
            this.name == "24" ||
            this.name == "29" ||
            this.name == "28" ||
            this.name == "31" ||
            this.name == "32" ||
            this.name == "33" ||
            this.name == "34"
            )
            GlobalVariables.S.score += 1;
    }
}
