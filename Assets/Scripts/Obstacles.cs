using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.ReorderableList.Element_Adder_Menu;
using UnityEditor.AnimatedValues;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    
    public float impulsePower = 5.0f;

    private void OnCollisionEnter(Collision collision)
    {
        Vector3 direction = transform.forward - collision.transform.position;
        collision.gameObject.GetComponent<Rigidbody>().AddForce(direction * impulsePower, ForceMode.Impulse);
    }

}
