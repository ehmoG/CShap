using UnityEngine;
using System.Collections;
using Unity.VisualScripting;

public class StackDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Stack stack = new Stack();

        stack.Push("ù ��°");
        stack.Push("�� ��°");
        stack.Push("�� ��°");

        Debug.Log(stack.Pop());
        Debug.Log(stack.Pop());
        Debug.Log(stack.Pop());
    }
}
