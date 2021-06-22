using System.Collections;
using System.Collections.Generic;
using Sentry;
using UnityEngine;

public class ErrorScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private float _lastTime;
    // Update is called once per frame
    void Update()
    {
        if (Time.time - _lastTime > 1f)
        {
            _lastTime = Time.time;
            Debug.LogError("Test error");
            SentrySdk.CaptureMessage("I was right");
        }
    }
}
