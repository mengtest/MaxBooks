﻿#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using XLua;
using System.Collections.Generic;


namespace XLua.CSObjectWrap
{
    using XUtils = XLua.XUtils;
    public class xcDBDeadSpaceLvWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			XUtils.BeginObjectRegister(typeof(xc.DBDeadSpaceLv), L, translator, 0, 3, 0, 0);
			
			XUtils.RegisterFunc(L, XUtils.METHOD_IDX, "Unload", _m_Unload);
			XUtils.RegisterFunc(L, XUtils.METHOD_IDX, "GetDeadSpaceLvInfo", _m_GetDeadSpaceLvInfo);
			XUtils.RegisterFunc(L, XUtils.METHOD_IDX, "GetMaxScoreDeadSpaceLvInfo", _m_GetMaxScoreDeadSpaceLvInfo);
			
			
			
			
			XUtils.EndObjectRegister(typeof(xc.DBDeadSpaceLv), L, translator, null, null,
			    null, null, null);

		    XUtils.BeginClassRegister(typeof(xc.DBDeadSpaceLv), L, __CreateInstance, 1, 1, 0);
			
			
            
            XUtils.RegisterObject(L, translator, XUtils.CLS_IDX, "UnderlyingSystemType", typeof(xc.DBDeadSpaceLv));
			XUtils.RegisterFunc(L, XUtils.CLS_GETTER_IDX, "Instance", _g_get_Instance);
            
			
			XUtils.EndClassRegister(typeof(xc.DBDeadSpaceLv), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 3 && (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING) && (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING))
				{
					string strName = LuaAPI.lua_tostring(L, 2);
					string strPath = LuaAPI.lua_tostring(L, 3);
					
					xc.DBDeadSpaceLv __cl_gen_ret = new xc.DBDeadSpaceLv(strName, strPath);
					translator.Push(L, __cl_gen_ret);
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to xc.DBDeadSpaceLv constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Unload(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            xc.DBDeadSpaceLv __cl_gen_to_be_invoked = (xc.DBDeadSpaceLv)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.Unload(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetDeadSpaceLvInfo(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            xc.DBDeadSpaceLv __cl_gen_to_be_invoked = (xc.DBDeadSpaceLv)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    uint id = LuaAPI.xlua_touint(L, 2);
                    
                        xc.DBDeadSpaceLv.DeadSpaceLvInfo __cl_gen_ret = __cl_gen_to_be_invoked.GetDeadSpaceLvInfo( id );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetMaxScoreDeadSpaceLvInfo(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            xc.DBDeadSpaceLv __cl_gen_to_be_invoked = (xc.DBDeadSpaceLv)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                        xc.DBDeadSpaceLv.DeadSpaceLvInfo __cl_gen_ret = __cl_gen_to_be_invoked.GetMaxScoreDeadSpaceLvInfo(  );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Instance(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.Push(L, xc.DBDeadSpaceLv.Instance);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
