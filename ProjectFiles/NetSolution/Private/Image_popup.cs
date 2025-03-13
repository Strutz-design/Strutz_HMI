using System;
using UAManagedCore;

//-------------------------------------------
// WARNING: AUTO-GENERATED CODE, DO NOT EDIT!
//-------------------------------------------

[MapType(NamespaceUri = "Strutz_HMI", Guid = "5bbcff2bce41cdfb0bd53a6b3bf6a074")]
public class Image_popup : UAObject
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
    public FTOptix.Core.ResourceUri Image
    {
        get
        {
            return new FTOptix.Core.ResourceUri(Refs.GetVariable("Image").Value);
        }
        set
        {
            Refs.GetVariable("Image").SetValue((string)value);
        }
    }
    public IUAVariable ImageVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Image");
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
#endregion
}
