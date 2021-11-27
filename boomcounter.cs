using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class boomcounter : MonoBehaviour
{
    public Image[] boomimage;
    

    public void UpdateBoomicon(int boomCount)
    {
        for (int index = 0; index < 3; index++)
        {
            boomimage[index].color = new Color(1, 1, 1, 0);
        }

        for (int index = 0; index < boomCount; index++)
        {
            boomimage[index].color = new Color(1, 1, 1, 1);
        }
    }
}
