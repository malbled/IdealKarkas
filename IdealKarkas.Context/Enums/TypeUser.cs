using System.ComponentModel;

namespace IdealKarkas.Context.Enums
{
    public enum TypeUser
    {
        [Description("Системный администратор")]
        Root,

        [Description("Администратор")]
        Admin,

        [Description("Менеджер")]
        Manager,

        [Description("Пользователь")]
        Member
    }
}
