using System.Diagnostics.CodeAnalysis;

namespace BlazorApp.Data
{
    public class MenuItem
    {
        [DisallowNull]
        public int Index { get; set; }  //排序索引

        [DisallowNull]
        public string Path { get; set; }  //路由相对路径

        [DisallowNull]
        public string Title { get; set; }  //菜单标题

        public string TitleEN { get; set; }  //菜单标题（英文）

        public string IconClass { get; set; }  //菜单图标

    }

    public enum Regions
    {
        CHS,
        CHT,
        EN
    }
}
