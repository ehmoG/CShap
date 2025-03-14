using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class StackOfType : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Stack<string> stack = new Stack<string>();

        stack.Push("10");
        stack.Push("TEN");

        Debug.Log($"{stack.Pop()}");
        Debug.Log($"{stack.Pop()}");
    }
}