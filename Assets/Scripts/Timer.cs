using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;

public class Timer : MonoBehaviour
{
    public float      currTime;
    public GameObject restaurantBG;
    
    private StudioEventEmitter emitter;

    // Start is called before the first frame update
    void Start()
    {
        currTime = 0;
        emitter = restaurantBG.GetComponent<FMODUnity.StudioEventEmitter>();
    }

    // Update is called once per frame
    void Update()
    {
        if (currTime < 0.8f)
        {
            currTime += (Time.deltaTime * 0.01f);
            emitter.SetParameter("Walla", currTime);
        }
    }
}
