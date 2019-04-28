using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpDown : MonoBehaviour {
    public static int mainCount;
    public GameObject tekst;
    public int intCount;

    private void Update()
    {
        intCount = mainCount;
        tekst.GetComponent<Text>().text = "0" + intCount;
    }


}
