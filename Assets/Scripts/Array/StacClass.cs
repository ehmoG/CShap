using UnityEngine;
using System.Collections;
using Unity.VisualScripting;

public class StacClass : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Stack st = new Stack();
        //Stack������ �ֱ� Push
        st.Push("First");
        st.Push("Second");
        //Stack������ ���ױ� Pop
        Debug.Log(st.Pop());
        Debug.Log(st.Pop());

    }
}
