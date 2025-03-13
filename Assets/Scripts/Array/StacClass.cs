using UnityEngine;
using System.Collections;
using Unity.VisualScripting;

public class StacClass : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Stack st = new Stack();
        //Stack데이터 넣기 Push
        st.Push("First");
        st.Push("Second");
        //Stack데이터 꺼네기 Pop
        Debug.Log(st.Pop());
        Debug.Log(st.Pop());

    }
}
