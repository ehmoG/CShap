using UnityEngine;

public class StringDisplay : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        var displayName = "";
        var firstName = "�浿";
        var lastName = "ȫ";

        displayName = "�̸�: " + lastName + firstName;
        Debug.Log(displayName);

        displayName = string.Format("�̸�: {0}{1}", lastName, firstName);
        Debug.Log(displayName);
        
        displayName = $"�̸�: {lastName}{firstName}";
        Debug.Log(displayName);
    }
}
