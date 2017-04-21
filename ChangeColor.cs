using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour 

       
   {
    gameObject.GetComponent<Renderer>().material.color = Color.green;
}
