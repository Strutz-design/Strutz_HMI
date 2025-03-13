using System;
using UAManagedCore;

//-------------------------------------------
// WARNING: AUTO-GENERATED CODE, DO NOT EDIT!
//-------------------------------------------

[MapType(NamespaceUri = "Strutz_HMI", Guid = "733a2ca6a46e53b4390d2cee78a21dc2")]
public class OverloadFaultButton : UAObject
{
#region Children properties
    //-------------------------------------------
    // WARNING: AUTO-GENERATED CODE, DO NOT EDIT!
    //-------------------------------------------
    public UAManagedCore.LocalizedText Name
    {
        get
        {
            return (UAManagedCore.LocalizedText)Refs.GetVariable("Name").Value.Value;
        }
        set
        {
            Refs.GetVariable("Name").SetValue(value);
        }
    }
    public IUAVariable NameVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Name");
        }
    }
    public bool PLC_Tag
    {
        get
        {
            return (bool)Refs.GetVariable("PLC_Tag").Value.Value;
        }
        set
        {
            Refs.GetVariable("PLC_Tag").SetValue(value);
        }
    }
    public IUAVariable PLC_TagVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("PLC_Tag");
        }
    }
    public UAManagedCore.NodeId Alias1
    {
        get
        {
            return (UAManagedCore.NodeId)Refs.GetVariable("Alias1").Value.Value;
        }
        set
        {
            Refs.GetVariable("Alias1").SetValue(value);
        }
    }
    public FTOptix.Core.Alias Alias1Variable
    {
        get
        {
            return (FTOptix.Core.Alias)Refs.GetVariable("Alias1");
        }
    }
#endregion
}
