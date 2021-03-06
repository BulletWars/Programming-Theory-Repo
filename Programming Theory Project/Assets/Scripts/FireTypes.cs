using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireTypes : MonoBehaviour
{
    [SerializeField] GameObject[] types;
    public int index { get; private set; }
    Vector3 createPos;
    bool isFire;
    [SerializeField] GameObject rect;
    [SerializeField] GameObject up;
    // Start is called before the first frame update
    void Start()
    {
        up.gameObject.SetActive(true);
        rect.gameObject.SetActive(false);
        isFire = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            index = 0;
            up.gameObject.SetActive(true);
            rect.gameObject.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            index = 1;
            up.gameObject.SetActive(false);
            rect.gameObject.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isFire)
            {
                StartCoroutine(TimeToFire());
                createPos = new Vector3(transform.position.x, transform.position.y, transform.position.y - 5);
                Instantiate(types[index], createPos, types[index].transform.rotation);
            }
        }
    }
    IEnumerator TimeToFire()
    {
            isFire = false;
            yield return new WaitForSeconds(0.5f);
            isFire = true;
    }
 
}
