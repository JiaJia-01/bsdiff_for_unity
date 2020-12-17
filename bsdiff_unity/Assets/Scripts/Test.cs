using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    [DllImport("bsdiff")]        
    private static extern int test(int a, int b);

    void Start()
    {
        GetComponent<Text>().text = test(1, 2).ToString();
    }
}