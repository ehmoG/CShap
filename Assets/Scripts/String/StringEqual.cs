using UnityEngine;

public class StringEqual : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string userName = "RedPlus";
        string inputName = "redPluse";
        
        if (userName.ToLower() == inputName.ToLower()) Debug.Log("�����ϴ�.");

        if(string.Equals(userName, inputName,System.StringComparison.InvariantCultureIgnoreCase)) Debug.Log("�����ϴ�.");
    }
}
