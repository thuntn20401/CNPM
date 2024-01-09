﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beans
{
    public class User
    {
        public string username { set; get; }
        public string password { set; get; }
        public string firstName { set; get; }
        public string lastName { set; get; }
        public string address { set; get; }
        public DateTime birthday { set; get; }
        public string gender { set; get; }
        public string phone { set; get; }
        public string email { set; get; }
        public string role { set; get; }
        public List<Order> listOrder { set; get; }
        public DataTable orderTable { set; get; }

    }
}
