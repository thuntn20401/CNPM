﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLLayer;

namespace QuanLyThuVien
{
    public partial class formDangNhap : Form
    {
        public formDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {

            string name = txtUSER.Text.ToString();
            string pass = txtPASS.Text.ToString();
            user user = new user(name,pass);

            BLL_DangNhap check = new BLL_DangNhap(name, pass);
            string kt = check.dangNhap(user);

            if (kt == "docgia")
            {
                Form formDocGia = new formDocGia(name,pass);
                this.Hide();
                formDocGia.ShowDialog();
                this.Close();
            }
            else
            { 
                if (kt == "nhanvien")
                {
                    Form formThuThu = new form_ThuThu(name,pass);
                    this.Hide();
                    formThuThu.ShowDialog();
                    this.Close();
                }
                else
                {
                    if (kt == "admin")
                    {
                        Form formAdmin = new formAdmin(name, pass);
                        this.Hide();
                        formAdmin.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("User hoặc pass không đúng !");
                    }
                }
              
            }

           
            // Form formThuThu = new form_ThuThu();
            // formThuThu.ShowDialog();
        }
    }
}
