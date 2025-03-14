using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class ListOfString : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        List<string> Color = new List<string>();
        Color.Add("Red");
        Color.Add("Green");
        Color.Add("Blue");
        
        foreach (var s in Color)
        {
            Color.Add(s);
        }
    }
}
