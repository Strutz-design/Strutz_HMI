using System;
using UAManagedCore;

//-------------------------------------------
// WARNING: AUTO-GENERATED CODE, DO NOT EDIT!
//-------------------------------------------

[MapType(NamespaceUri = "Strutz_HMI", Guid = "5b9b51df0ba4ac19fc7b81d844ba05b3")]
public class ObjectHeaterRunControl : UAObject
{
#region Children properties
    //-------------------------------------------
    // WARNING: AUTO-GENERATED CODE, DO NOT EDIT!
    //-------------------------------------------
    public UAManagedCore.LocalizedText Title
    {
        get
        {
            return (UAManagedCore.LocalizedText)Refs.GetVariable("Title").Value.Value;
        }
        set
        {
            Refs.GetVariable("Title").SetValue(value);
        }
    }
    public IUAVariable TitleVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Title");
        }
    }
    public int Current
    {
        get
        {
            return (int)Refs.GetVariable("Current").Value.Value;
        }
        set
        {
            Refs.GetVariable("Current").SetValue(value);
        }
    }
    public IUAVariable CurrentVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Current");
        }
    }
    public int FDbk
    {
        get
        {
            return (int)Refs.GetVariable("FDbk").Value.Value;
        }
        set
        {
            Refs.GetVariable("FDbk").SetValue(value);
        }
    }
    public IUAVariable FDbkVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("FDbk");
        }
    }
    public bool OnOff_control
    {
        get
        {
            return (bool)Refs.GetVariable("OnOff_control").Value.Value;
        }
        set
        {
            Refs.GetVariable("OnOff_control").SetValue(value);
        }
    }
    public IUAVariable OnOff_controlVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("OnOff_control");
        }
    }
    public int Overload_Reset
    {
        get
        {
            return (int)Refs.GetVariable("Overload_Reset").Value.Value;
        }
        set
        {
            Refs.GetVariable("Overload_Reset").SetValue(value);
        }
    }
    public IUAVariable Overload_ResetVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Overload_Reset");
        }
    }
    public bool Overload
    {
        get
        {
            return (bool)Refs.GetVariable("Overload").Value.Value;
        }
        set
        {
            Refs.GetVariable("Overload").SetValue(value);
        }
    }
    public IUAVariable OverloadVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Overload");
        }
    }
    public int Run_Setting
    {
        get
        {
            return (int)Refs.GetVariable("Run_Setting").Value.Value;
        }
        set
        {
            Refs.GetVariable("Run_Setting").SetValue(value);
        }
    }
    public IUAVariable Run_SettingVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Run_Setting");
        }
    }
#endregion
}
