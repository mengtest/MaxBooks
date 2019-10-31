﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UILoad : UIPage
{
    public GameObject round;
    Vector3 rolling = new Vector3(0, 0, 1.0f);
    private BinProcess binProcess;
    private AbProcess abProcess;
    private List<PreProcess> processList;
    private int index;
    protected override void InitComp()
    {

    }

    protected override void InitData()
    {

    }

    private void Start()
    {
        binProcess = new BinProcess();
        abProcess = new AbProcess();
        //Debug.Log(binProcess.num);
        //Debug.Log(abProcess.num);
        processList = new List<PreProcess>();
        processList.Add(binProcess);
        processList.Add(abProcess);
        index = 0;
        processList[index].Process();
        //Debug.Log(processList[index].Progress);
        //Debug.Log(processList[index].num);
    }

    private void Update()
    {
        round.transform.Rotate(rolling);

        if(processList[index].Progress==processList[index].num)
        {
            if(index<processList.Count-1)
            {
                index++;
                processList[index].Process();
            }
            else
            {
                UIMgr.ShowPage(UIPageEnum.Main_Page);
            }
        }
    }
}
