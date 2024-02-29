
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
public sealed partial class DRStartMachineConfig : Luban.BeanBase
{
    public DRStartMachineConfig(ByteBuf _buf) 
    {
        StartConfig = _buf.ReadString();
        Id = _buf.ReadInt();
        InnerIP = _buf.ReadString();
        OuterIP = _buf.ReadString();
        WatcherPort = _buf.ReadString();
        PostInit();
    }

    public static DRStartMachineConfig DeserializeDRStartMachineConfig(ByteBuf _buf)
    {
        return new DRStartMachineConfig(_buf);
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
    /// 内网地址
    /// </summary>
    public readonly string InnerIP;
    /// <summary>
    /// 外网地址
    /// </summary>
    public readonly string OuterIP;
    /// <summary>
    /// 守护进程端口
    /// </summary>
    public readonly string WatcherPort;
    public const int __ID__ = -929351083;
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
        + "InnerIP:" + InnerIP + ","
        + "OuterIP:" + OuterIP + ","
        + "WatcherPort:" + WatcherPort + ","
        + "}";
    }

    partial void PostInit();
    partial void PostResolveRef();
}
}
