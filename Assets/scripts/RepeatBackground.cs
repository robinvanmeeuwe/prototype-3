using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private Vector3 startPos;
    private float repeatWitdth;
    // Start is called before the first frame update
    void Start()
    {
        // achtergrond oneiding latene worden
        startPos = transform.position;
        repeatWitdth = GetComponent<BoxCollider>().size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < startPos.x -repeatWitdth)
        { 
            transform.position = startPos;
            { 
                transform.position = startPos;
            }
        }
    }
}
