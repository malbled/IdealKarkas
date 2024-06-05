using IdealKarkas.Context.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdealKarkas.WinForms
{
    internal static class WorkToClient
    {
        private static Client client;

        public static Client Client
        {
            get
            {
                if (client == null)
                {
                    client = new Client()
                    {
                        Id = -1,
                        LastName = "Гость не добавлен",
                    };
                }
                return client;
            }
            set { client = value; }
        }
    }
}
