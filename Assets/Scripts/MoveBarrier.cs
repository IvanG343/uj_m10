using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBarrier : MonoBehaviour
{

    public float moveDistance = 2.0f;
    public float moveSpeed = 2.0f;

    private Vector3 startPos;
    private float time = 0.0f;

    private void Start()
    {
        startPos = transform.position;
    }

    private void Update()
    {
        time += moveSpeed * Time.deltaTime;
        float xOffset = Mathf.Sin(time) * moveDistance;
        if(gameObject.name == "BarrierRight")
        {
            transform.position = startPos + new Vector3(xOffset, 0f, 0f);
        }
        else
        {
            transform.position = startPos + new Vector3((xOffset * -1), 0f, 0f);
        }
        
    }

}
