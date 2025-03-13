using UnityEngine;
using System.Collections;
using Unity.VisualScripting;

public class PublicClass : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Stack st =new Stack();
        st.Push("대한민국");
        st.Push("나일라");
        st.Push("강동구");

        if (st.Count < 0)
        {
            st.Pop();
            Debug.Log($"{st.Peek()}, {st.Count}");
        }
        st.Clear();
        Debug.Log($"{st.Peek()}, {st.Count}");
    }
}
