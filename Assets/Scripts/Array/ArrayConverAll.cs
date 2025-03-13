using Unity.VisualScripting;
using UnityEngine;

public class ArrayConverAll : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string[] strArray = { "10", "20", "30" };
        int[] intArray = System.Array.ConvertAll(strArray, int.Parse);

        foreach (int i in intArray)
            Debug.Log(i);

    }
}
