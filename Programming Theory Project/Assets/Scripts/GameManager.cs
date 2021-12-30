using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject spawn1;
    public GameObject spawn2;
    public GameObject end;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.Find("Player") == null)
        {
            Destroy(spawn1);
            Destroy(spawn2);
            end.gameObject.SetActive(true);
            if (Input.GetKeyDown(KeyCode.Return))
            {
                MainManager.instance.Destroy();
                SceneManager.LoadScene("title");
            }
        }
    }
}
