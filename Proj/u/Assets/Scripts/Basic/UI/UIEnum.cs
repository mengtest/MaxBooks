﻿using System;
using System.Collections.Generic;

public enum UIPageEnum
{
    MainTown_Page = 1,//主界面
    SimPleWindows_Wind,//示范用windows
    SimTips_Tips,//示范用tips
    Main_Page,
    BG_Page,
    MainUI_Page,
    PlayField_Page,
    LevelList_Page,
    Tips_Page,

    Effect_Tips,

    Play_Page,
    GM_Page,
    UseRec_Tips,
    // Pause_Page,

    End_Page,
    Max,
}
public static class UIUtil
{

    public static Dictionary<int, string> m_DicUI = new Dictionary<int, string>() {
        {(int)UIPageEnum.MainTown_Page,typeof(UIMainTown).ToString()},
        {(int)UIPageEnum.SimPleWindows_Wind,typeof(UISimPleWindows).ToString()},
        {(int)UIPageEnum.SimTips_Tips,typeof(UISimTips).ToString()},
        {(int)UIPageEnum.Main_Page,typeof(UIMain).ToString()},
        {(int)UIPageEnum.LevelList_Page,typeof(UILevelList).ToString()},
        {(int)UIPageEnum.Tips_Page,typeof(UITips).ToString()},
        {(int)UIPageEnum.Effect_Tips,typeof(UIEffect).ToString()},
        {(int)UIPageEnum.Play_Page,typeof(UIPlay).ToString()},
        {(int)UIPageEnum.GM_Page,typeof(UIGM).ToString()},
        {(int)UIPageEnum.UseRec_Tips,typeof(UIUseRecTips).ToString()},
        // {(int)UIPageEnum.Pause_Page,typeof(UIPause).ToString()},

        {(int)UIPageEnum.End_Page,typeof(UIEnd).ToString()},

    };
    public static string GetUITypeName(int uiid)
    {
        if (m_DicUI.ContainsKey(uiid))
        {
            return m_DicUI[uiid];
        }
        return string.Empty;
    }
}