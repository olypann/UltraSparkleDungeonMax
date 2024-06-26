using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextScript : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;

    private int index;
    // Start is called before the first frame update
    void Start()
    {
        textComponent.text = string.Empty;
        StartText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void StartText()
    {
        Debug.Log("testing");
        index = 0;
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {
        Debug.Log("111");
        foreach (char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            Debug.Log("char");
            yield return new WaitForSeconds(textSpeed);
        }
    }
}
