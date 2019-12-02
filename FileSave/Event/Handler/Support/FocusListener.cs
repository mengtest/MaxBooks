﻿// --- NEROKING.COM ------------------------------------------------------------------------------------------------------------------------------------------------------- //

using static TraceTool;
using UnityEngine;
using System;
using System.Collections.Generic;

namespace NF.Core.Event.Handler.Support {
    // 程序焦点事件侦听
    internal class FocusListener : BaseListener {

        // --- Field & Property ------------------------------------------------------------------------------------------------------------------------------------------- //

        // 侦听函数
        internal Action<bool> Listener { get; set; }

        // --- Public & Protected Function -------------------------------------------------------------------------------------------------------------------------------- //

        // --- Internal Function ------------------------------------------------------------------------------------------------------------------------------------------ //
        
        // 派发事件 ( 重写 )
        internal override void Dispatch( params object[] args ) => Listener.Invoke( (bool)args[0] );

        // --- Private Function ------------------------------------------------------------------------------------------------------------------------------------------- //

    }
}

// ------------------------------------------------------------------------------------------------------------------------------------------------------------------------ //
