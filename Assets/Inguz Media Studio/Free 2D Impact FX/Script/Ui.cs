using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Ui : MonoBehaviour
{
    public static Ui instance;
    private void Awake()
    {
        instance = this;
    }
    [SerializeField]private TMP_Text killCount;
    private int killCountInt = 0;

    public void AddCount()
    {
        killCountInt += 1;
        killCount.text = "KILLED:"+killCountInt;
    }
}
