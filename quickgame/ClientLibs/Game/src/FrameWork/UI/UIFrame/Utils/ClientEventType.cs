using ClientEventType;
namespace ClientEventType.ugui
{
    public enum UICoreEvent : byte
    {
		UILOADDONE,
        WINDOW_SHOW,
        WINDOW_HIDE,
        WINDOW_DESTROY,
        KEYBOARD_CHANGE,//增加keyBoard事件用作传递键盘
		LEVEL_CHANGE,//場景切換
    }
}