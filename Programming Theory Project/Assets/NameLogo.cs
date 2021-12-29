using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameLogo : MonoBehaviour
{
    public TextMesh nameText;
    // Start is called before the first frame update
    void Start()
    {
        nameText = GetComponentInChildren<TextMesh>();
        nameText.text = MainManager.instance.nameString;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
