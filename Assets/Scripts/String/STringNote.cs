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

        Debug.Log("�յ� ��������"+str.Trim());
        Debug.Log("���ڿ� �պκ� ��������" + str.TrimStart());
        Debug.Log("���ڿ� �޺κ� ��������" + str.TrimEnd());

        Debug.Log("e��ġ ��������" + str.IndexOf('e'));
        Debug.Log("5��°���� 3��°����" + str.Substring(5, 3));
        Debug.Log("5��°���� ��������" + str.Substring(5));
        Debug.Log("5��°���� 3��°���� ����" + str.Remove(5, 3));

        Debug.Log($"������: {str[1] == str[15]}");
        Debug.Log("������"+"ABC".Equals("Abc"));
        Debug.Log("0(����), 1(�տ��� ũ��(<)), -1(�տ��� ������(>)): "+System.String.Compare("BAC", "Bac"));

        var h1 = "�ȳ�";
        var h2 = "�ϼ���";
        Debug.Log(h1 + h2);
        Debug.Log($"{h1}{h2}");
        Debug.Log(System.String.Format("[0][1]", h1, h2));

        Debug.Log("��ȭ��" + System.String.Format("{0:C}", 1000));
        Debug.Log(System.String.Format("{0}", 100000));

        string[] stra = str.Trim().Split(' ');

        foreach (var s in stra) ;
    }

}
