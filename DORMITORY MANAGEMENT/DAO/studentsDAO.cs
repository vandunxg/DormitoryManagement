﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DORMITORY_MANAGEMENT.DAO
{
    public class studentsDAO
    {
        #region Declaration 

        private static studentsDAO instance;

        private studentsDAO() { }

        public static studentsDAO Instance
        {
            get { if (instance == null) instance = new studentsDAO(); return studentsDAO.instance; }
            private set { instance = value; }

        }

        #endregion

        #region Method 

        public bool checkRepeatInformation(string textNeedCheck, string query)
        {

            DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { textNeedCheck });

            if (data.Rows.Count == 1)
                return true;

            return false;
        }

        public bool checkValidNumberPhone(string number)
        {
            string regexPattern = @"^(84|0[3|5|7|8|9])([0-9]{8})$";
            if (!System.Text.RegularExpressions.Regex.IsMatch(number, regexPattern))
            {
                return false;
            }

            return true;
        }

        public bool checkValidNumber(string number)
        {
            string regexPattern = @"^\d{12}$";
            if (!System.Text.RegularExpressions.Regex.IsMatch(number, regexPattern))
            {
                return false;
            }

            return true;
        }

        #endregion


    }
}
