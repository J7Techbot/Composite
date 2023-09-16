using System.Text;

namespace HW5.Helpers
{
    public static class DashHelper
    {
        /// <summary>
        /// Create string with dashes.
        /// </summary>
        /// <param name="count">Count of dashes in string.</param>
        /// <returns></returns>
        public static string GetDashes(int count)
        {
            StringBuilder dashes = new StringBuilder();

            for (int i = 0; i < count; i++)
            {
                dashes.Append("-");
            }

            return dashes.ToString();
        }
    }
}
