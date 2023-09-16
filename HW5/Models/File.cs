using HW5.Helpers;
using HW5.Interface;

namespace HW5.Models
{
    public class File : SysFileComponent
    {
        private string name;

        public File(string name)
        {
            this.name = name;
        }

        public void DisplayInfo(int level)
        {
            level++;

            Console.WriteLine($"{DashHelper.GetDashes(level)}File: {name}");
        }
    }
}
