using System;
using System.Windows.Forms;

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


namespace DORMITORY_MANAGEMENT
{
    public partial class Card_ShowInfo : UserControl
    {
        public Card_ShowInfo()
        {
            InitializeComponent();
        }

        public Card_ShowInfo(string CardName, string Money)
        {
            InitializeComponent();
            lbl_name.Text = CardName;
            lbl_money.Text = Money + "đ";
        }

        #region Declaration
        public string TextLabel
        {
            get => textLabel;
            set
            {
                textLabel = value;
                lbl_name.Text = textLabel;

            }
        }

        public string Money
        {
            get => money;
            set
            {
                money = value;
                lbl_money.Text = money + "đ";
            }
        }



        private string textLabel;
        private string money;
        #endregion


        #region Events

        private void cardShowInfo_Load(object sender, EventArgs e)
        {

        }

        #endregion

        #region Method

        public void setAllValue(string name, string money)
        {
            lbl_name.Text = name;
            lbl_money.Text = money;
        }

        #endregion
    }
}
