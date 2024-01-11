using System.Data;
using System.Text.RegularExpressions;

/*
    Author : @vandunxg
    Github : @vandunxg
    Blog : vandunxg.vercel.app
    Leetcode : @vandunxg
    Facebook : @vandunxg
*/

/* Copyright (C) 2024 Nguyen Van Dung - All Rights Reserved
 * You may use, distribute and modify this code under the
 * terms of the MIT license, which unfortunately won't be
 * written for another century.
 *
 * You should have received a copy of the MIT license with
 * this file. If not, please write to: vandunxg.dev@gmail.com, or visit : vandunxg.vercel.app
 */


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

        public bool checkValidEmail(string email)
        {
            string regex = @"^((([a-z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{\|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+(\.([a-z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{\|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+)*)|((\x22)((((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(([\x01-\x08\x0b\x0c\x0e-\x1f\x7f]|\x21|[\x23-\x5b]|[\x5d-\x7e]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(\\([\x01-\x09\x0b\x0c\x0d-\x7f]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF]))))*(((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(\x22)))@((([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.)+(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.?$";

            return Regex.IsMatch(email, regex, RegexOptions.IgnoreCase);
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
