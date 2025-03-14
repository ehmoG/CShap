using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GenericDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Stack st1 = new Stack();
        st1.Push(1234);

        int num1 = (int)st1.Pop();
        Debug.Log($"{num1}");

        Stack<int> st2 = new Stack<int>();

        st2.Push(5678);
        int num2 = st2.Pop();
        Debug.Log($"{num2}");

        Stack o = new Stack();
        o.Push(1234);
        o.Push("Hello");
        Debug.Log($"{o.Pop()}");
        Debug.Log($"{o.Pop()}");

        Stack<int> i = new Stack<int>();
        i.Push(2345);
        Debug.Log($"{i.Pop()}");

        Stack stack = new Stack();
        stack.Push(1234);
        int ist = (int)stack.Pop();
        Debug.Log($"{ist}");
    }
}
