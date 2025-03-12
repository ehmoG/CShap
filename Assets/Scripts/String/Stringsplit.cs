using UnityEngine;

public class Stringsplit : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string scr = "Red,Green,Blue";
        string[] color = scr.Split(',');

        for(int i=0; i<color.Length; i++) Debug.Log(color[i]);
    }
}
