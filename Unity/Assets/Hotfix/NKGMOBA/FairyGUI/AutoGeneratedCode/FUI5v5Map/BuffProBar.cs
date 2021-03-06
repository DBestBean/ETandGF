/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using ETModel;

namespace ETHotfix
{
    [ObjectSystem]
    public class BuffProBarAwakeSystem : AwakeSystem<BuffProBar, GObject>
    {
        public override void Awake(BuffProBar self, GObject go)
        {
            self.Awake(go);
        }
    }
        
    public sealed class BuffProBar : FUI
    {	
        public const string UIPackageName = "FUI5v5Map";
        public const string UIResName = "BuffProBar";
        
        /// <summary>
        /// {uiResName}的组件类型(GComponent、GButton、GProcessBar等)，它们都是GObject的子类。
        /// </summary>
        public GProgressBar self;
            
    public GImage n2;
    public GImage bar;
    public const string URL = "ui://9sdz56q4qraf6c";

    private static GObject CreateGObject()
    {
        return UIPackage.CreateObject(UIPackageName, UIResName);
    }
    
    private static void CreateGObjectAsync(UIPackage.CreateObjectCallback result)
    {
        UIPackage.CreateObjectAsync(UIPackageName, UIResName, result);
    }
        
    public static BuffProBar CreateInstance()
    {			
        return ComponentFactory.Create<BuffProBar, GObject>(CreateGObject());
    }
        
    public static ETTask<BuffProBar> CreateInstanceAsync(Entity domain)
    {
        ETTaskCompletionSource<BuffProBar> tcs = new ETTaskCompletionSource<BuffProBar>();
        CreateGObjectAsync((go) =>
        {
            tcs.SetResult(ComponentFactory.Create<BuffProBar, GObject>(go));
        });
        return tcs.Task;
    }
        
    public static BuffProBar Create(GObject go)
    {
        return ComponentFactory.Create<BuffProBar, GObject>(go);
    }
        
    /// <summary>
    /// 通过此方法获取的FUI，在Dispose时不会释放GObject，需要自行管理（一般在配合FGUI的Pool机制时使用）。
    /// </summary>
    public static BuffProBar GetFormPool(GObject go)
    {
        var fui = go.Get<BuffProBar>();
        if(fui == null)
        {
            fui = Create(go);
        }
        fui.isFromFGUIPool = true;
        return fui;
    }
        
    public void Awake(GObject go)
    {
        if(go == null)
        {
            return;
        }
        
        GObject = go;	
        
        if (string.IsNullOrWhiteSpace(Name))
        {
            Name = Id.ToString();
        }
        
        self = (GProgressBar)go;
        
        self.Add(this);
        
        var com = go.asCom;
            
        if(com != null)
        {	
            
    		n2 = (GImage)com.GetChildAt(0);
    		bar = (GImage)com.GetChildAt(1);
    	}
}
       public override void Dispose()
       {
            if(IsDisposed)
            {
                return;
            }
            
            base.Dispose();
            
            self.Remove();
            self = null;
            
			n2 = null;
			bar = null;
		}
}
}