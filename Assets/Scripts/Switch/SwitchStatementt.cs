using System;
using UnityEngine;

public class SwitchStatementt : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("³¯½Ã¼±ÅÃ(¸¼À½, Èå¸², ºñ, ´«)");
        string[] wheater;
        wheater = new string[4] { "¸¼À½", "Èå¸²", "ºñ", "´«" };
        for (int x = 1, i = 0; i < wheater.Length; i++)
        {
            if (x >= 1)
                switch (x)
                {
                    case 0:
                        Debug.Log($"{wheater[i]}");
                        break;
                    case 1:
                        Debug.Log($"{wheater[i]}");
                        break;
                    case 2:
                        Debug.Log($"{wheater[i]}");
                        break;
                    case 3:
                        Debug.Log($"{wheater[i]}");
                        break;
                }
            else
                Debug.Log("´Ù½Ã");
        }
        
        
    }
}
