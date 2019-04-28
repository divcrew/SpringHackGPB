using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cliker : MonoBehaviour {
    public GameObject textBox;

    private void Update()
    {
        if (UpDown.mainCount >= 5)
        {
            UpDown.mainCount = 5;
        }
        if (UpDown.mainCount <= 1)
        {
            UpDown.mainCount = 1;
        }
    }

    public void Ctr()
    {
        UpDown.mainCount += 1;
    }

    public void down()
    {
        UpDown.mainCount -= 1;
    }
}
