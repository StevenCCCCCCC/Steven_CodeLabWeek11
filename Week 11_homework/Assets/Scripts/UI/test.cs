using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//this script is used for the test
public class test : MonoBehaviour
{
    public Text print;
    public Text name;
    public Text age;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    public void Update()
    {

        print.text = "Hello," + name.text + age.text;
    }


}
