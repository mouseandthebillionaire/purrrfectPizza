using System.Collections;
using System.Collections.Generic;
using FMODUnity;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public StudioEventEmitter bg_music;
    
    // Start is called before the first frame update
    void Start()
    {
        // turn on the sounds here to get around the webaudio user focus thingy
        foreach (Transform child in this.transform)
        {
            child.gameObject.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        bg_music.SetParameter("Progression", GlobalVariables.S.ingredientsPlayed);
    }
}
