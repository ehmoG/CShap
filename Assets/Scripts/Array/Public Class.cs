using UnityEngine;
using System.Collections;
using Unity.VisualScripting;

public class PublicClass : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Stack st =new Stack();
        st.Push("���ѹα�");
        st.Push("���϶�");
        st.Push("������");

        if (st.Count < 0)
        {
            st.Pop();
            Debug.Log($"{st.Peek()}, {st.Count}");
        }
        st.Clear();
        Debug.Log($"{st.Peek()}, {st.Count}");
    }
}
