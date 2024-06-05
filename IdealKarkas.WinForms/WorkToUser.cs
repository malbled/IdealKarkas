using IdealKarkas.Context.Enums;
using IdealKarkas.Context.Models;

namespace IdealKarkas.WinForms
{
    internal static class WorkToUser
    {
        private static Staff staff;

        public static Staff Staff
        {
            get
            {
                if (staff == null)
                {
                    staff = new Staff()
                    {
                        Id = -1,
                        LastName = "Неопознаный человек",
                        TypeUser = TypeUser.Member,
                    };
                }
                return staff;
            }
            set { staff = value; }
        }
    }
}
