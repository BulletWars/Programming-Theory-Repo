using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FontResize : MonoBehaviour
{
    bool isGreat;
    Text textSize;
    // Start is called before the first frame update
    void Start()
    {
        isGreat = false;
        textSize = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (textSize.fontSize == 80)
        {
            isGreat = true;
        }
        else if (textSize.fontSize == 0)
        {
            isGreat = false;
        }
        if (isGreat)
        {
            
            textSize.fontSize -= 1 ;
        }
        else if (!isGreat)
        {
            textSize.fontSize += 1;
        }
    }
}
