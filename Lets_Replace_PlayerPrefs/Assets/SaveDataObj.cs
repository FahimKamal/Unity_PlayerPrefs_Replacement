using UnityEngine;

public class SaveDataObj : MonoBehaviour
{
    public bool boolValue;
    public int intValue;
    public float floatValue;
    public string stringValue;

    [EButton.BeginHorizontal("Buttons"), EButton]
    public void SaveData()
    {
        FileHandler.Add("TestBool", boolValue);
        FileHandler.Add("TestInt", intValue);
        FileHandler.Add("TestFloat", floatValue);
        FileHandler.Add("TestString", stringValue);
    }

    [EButton, EButton.EndHorizontal]
    public void LoadData()
    {
        var loadedBool = FileHandler.GetBool("TestBool");
        var loadedInt = FileHandler.GetInt("TestInt", 0);
        var loadedFloat = FileHandler.GetFloat("TestFloat", 0.0f);
        var loadedString = FileHandler.GetString("TestString", "No Value");
        
        Debug.Log("The Bool value is: " + loadedBool);
        Debug.Log("The Int value is: " + loadedInt);
        Debug.Log("The Float value is: " + loadedFloat);
        Debug.Log("The String value is: " + loadedString);
    }

    [EButton]
    public void TestButton()
    {
        
    }
    
    [EButton]
    public void Test2Button()
    {
        
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
}
