using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PQ : MonoBehaviour
{
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
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    // Check Near
    // Who is in the 8 PQs around me?
    // Return an array?
    public IEnumerator CheckNear()
    {
        yield return null;
    }
    
    // Check Edge (i.e am I on the edge?)
    public bool CheckEdge()
    {
        // if ()
        // {
        // }
        // return true;
        // else
        return false;
    }
}
