using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeGravitationAxis : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Physics.gravity = new Vector3(0, 0, -9.81F);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
