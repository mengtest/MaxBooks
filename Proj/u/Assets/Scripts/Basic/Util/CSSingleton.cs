﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CSSingleton<T> where T:CSSingleton<T> ,new()
{
    private static T _ins = null;
    public static T GetInstance()
    {
        if (_ins == null)
        {
            _ins = new T();
            _ins.Init();
        }
        return _ins;
    }
    protected virtual void Init() { }
}
