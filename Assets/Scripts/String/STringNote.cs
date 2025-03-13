using System.Threading;
using UnityEngine;

public class STringNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string str = "";
        str = System.String.Empty;
        str = "Abc Def Fed Cba";
        Debug.Log(str);
        Debug.Log(str.Length);
        Debug.Log(str[5]);
        Debug.Log(str.ToUpper());
        Debug.Log(str.ToLower());

        Debug.Log("앞뒤 공백제거"+str.Trim());
        Debug.Log("문자열 앞부분 공백제거" + str.TrimStart());
        Debug.Log("문자열 뒷부분 공백제거" + str.TrimEnd());

        Debug.Log("e위치 가져오기" + str.IndexOf('e'));
        Debug.Log("5번째부터 3번째까지" + str.Substring(5, 3));
        Debug.Log("5번째부터 가져오기" + str.Substring(5));
        Debug.Log("5번째부터 3번째까지 삭제" + str.Remove(5, 3));

        Debug.Log($"참거짓: {str[1] == str[15]}");
        Debug.Log("참거짓"+"ABC".Equals("Abc"));
        Debug.Log("0(같음), 1(앞에가 크면(<)), -1(앞에가 작으면(>)): "+System.String.Compare("BAC", "Bac"));

        var h1 = "안녕";
        var h2 = "하세요";
        Debug.Log(h1 + h2);
        Debug.Log($"{h1}{h2}");
        Debug.Log(System.String.Format("[0][1]", h1, h2));

        Debug.Log("통화량" + System.String.Format("{0:C}", 1000));
        Debug.Log(System.String.Format("{0}", 100000));

        string[] stra = str.Trim().Split(' ');

        foreach (var s in stra) ;
    }

}
