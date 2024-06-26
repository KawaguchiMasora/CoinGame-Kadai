using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovBase : MonoBehaviour
{
    public Transform startMarker; 
    public Transform endMarker;   
    public float speed = 1.0f;    
    private float startTime;      
    private float journeyLength;  

    void Start()
    {
        startTime = Time.time;
        journeyLength = Vector3.Distance(startMarker.position, endMarker.position);
    }

    void Update()
    {
        float distCovered = (Time.time - startTime) * speed;
        float fracJourney = distCovered / journeyLength;

       
        transform.position = Vector3.Lerp(startMarker.position, endMarker.position, fracJourney);

      
        if (fracJourney >= 1.0f)
        {
            
            Transform temp = startMarker;
            startMarker = endMarker;
            endMarker = temp;

           
            startTime = Time.time;
        }
    }
}
