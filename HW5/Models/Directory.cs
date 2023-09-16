using HW5.Helpers;
using HW5.Interface;

namespace HW5.Models
{
    public class Directory : SysFileComponent
    {
        private string name;

        private IEnumerable<SysFileComponent> childComponents = new List<SysFileComponent>();

        public Directory(string name, IEnumerable<SysFileComponent> childComponents)
        {
            this.name = name;
            this.childComponents = childComponents;
        }
        public Directory(string name)
        {
            this.name = name;
        }

        public void DisplayInfo(int level)
        {
            level++;

            System.Console.WriteLine($"{DashHelper.GetDashes(level)}Directory: {name}");

            foreach (var child in childComponents)
            {
                child.DisplayInfo(level);
            }
        }
    }
}
