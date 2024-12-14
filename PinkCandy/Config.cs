using Exiled.API.Interfaces;
using System.ComponentModel;

namespace PinkCandy
{
    public sealed class Config : IConfig
    {
        [Description("启动粉糖插件")]
        public bool IsEnabled {  get; set; } = true;
        [Description("启动粉糖插件-Debug")]
        public bool Debug { get; set; } = true;
        [Description("粉糖刷新概率[1/参数]")]
        public ushort SpawnPinkCandy = 5;
    }
}
