using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitManager : MonoBehaviour
{
   public void AllFruitsColleted()
    {
        if (transform.childCount == 1)
        {
            Debug.Log("No quedan frutas");
        }
    }
}
