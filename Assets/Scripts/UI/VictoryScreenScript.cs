using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoryScreenScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void Setup()
    {
        gameObject.SetActive(true);
        Time.timeScale = 0;
    }

}
