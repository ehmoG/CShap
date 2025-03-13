using UnityEngine;
using System.Collections;
using Unity.VisualScripting;

public class StackDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Stack stack = new Stack();

        stack.Push("첫 번째");
        stack.Push("두 번째");
        stack.Push("세 번째");

        Debug.Log(stack.Pop());
        Debug.Log(stack.Pop());
        Debug.Log(stack.Pop());
    }
}
