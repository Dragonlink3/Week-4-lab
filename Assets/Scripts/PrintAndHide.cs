using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    public Renderer rend;
    int i;
    private GameObject myObj;

    // Start is called before the first frame update
    void Start()
    {
       i = 3; 
       myObj = this.gameObject;
       int generator = Random.Range(150,251);
	
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        Debug.Log(myObj.name + ":" + i);
        if (myObj.tag == "Red" && i == 100){
            myObj.SetActive(false);
        }
        if (myObj.tag == "Blue" && i == Random.Range(150,251)) {
            myObj.GetComponent<Renderer>().enabled=false; 
        }
    }
}
