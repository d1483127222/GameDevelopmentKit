
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;

namespace ET
{
[ET.EnableClass]
public sealed partial class DRStartProcessConfig : Luban.BeanBase
{
    public DRStartProcessConfig(ByteBuf _buf) 
    {
        StartConfig = _buf.ReadString();
        Id = _buf.ReadInt();
        MachineId = _buf.ReadInt();
        Port = _buf.ReadInt();
        PostInit();
    }

    public static DRStartProcessConfig DeserializeDRStartProcessConfig(ByteBuf _buf)
    {
        return new DRStartProcessConfig(_buf);
    }

    /// <summary>
    /// 开启类型
    /// </summary>
    public readonly string StartConfig;
    /// <summary>
    /// Id
    /// </summary>
    public readonly int Id;
    /// <summary>
    /// 所属机器
    /// </summary>
    public readonly int MachineId;
    /// <summary>
    /// 外网端口
    /// </summary>
    public readonly int Port;
    public const int __ID__ = -417016195;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
        
        
        
        
        PostResolveRef();
    }

    public override string ToString()
    {
        return "{ "
        + "StartConfig:" + StartConfig + ","
        + "Id:" + Id + ","
        + "MachineId:" + MachineId + ","
        + "Port:" + Port + ","
        + "}";
    }

    partial void PostInit();
    partial void PostResolveRef();
}
}
