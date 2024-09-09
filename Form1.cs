using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gidor_Helper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void user_Pannel_Leave(object sender, EventArgs e)
        {
            user_admin.BackColor = SystemColors.ControlLightLight;
            user_admin.BorderStyle = BorderStyle.None; 
        }

        private void user_Pannel_Move(object sender, MouseEventArgs e)
        {
            user_admin.BackColor = Color.LightBlue;
            user_admin.BorderStyle = BorderStyle.FixedSingle; 
        }

        private void commonCod_pannel_leave(object sender, EventArgs e)
        {
            common_cod.BackColor = SystemColors.ControlLightLight;
            common_cod.BorderStyle = BorderStyle.None;
        }

        private void commonCod_pannel_Move(object sender, MouseEventArgs e)
        {
            common_cod.BackColor = Color.LightBlue;
            common_cod.BorderStyle = BorderStyle.FixedSingle;
        }

        private void user_Pic_Leave(object sender, EventArgs e)
        {
            user_admin.BackColor = SystemColors.ControlLightLight;
            user_admin.BorderStyle = BorderStyle.None;
        }

        private void user_Pic_Move(object sender, MouseEventArgs e)
        {
            user_admin.BackColor = Color.LightBlue;
            user_admin.BorderStyle = BorderStyle.FixedSingle;
        }

        private void commonCod_Pic_Leave(object sender, EventArgs e)
        {
            common_cod.BackColor = SystemColors.ControlLightLight;
            common_cod.BorderStyle = BorderStyle.None;
        }

        private void commonCod_Pic_Move(object sender, MouseEventArgs e)
        {
            common_cod.BackColor = Color.LightBlue;
            common_cod.BorderStyle = BorderStyle.FixedSingle;
        }

        private void B2B_user_Pannel_leave(object sender, EventArgs e)
        {
            B2B_user.BackColor = SystemColors.ControlLightLight;
            B2B_user.BorderStyle = BorderStyle.None;
        }

        private void B2B_user_Pannel_move(object sender, MouseEventArgs e)
        {
            B2B_user.BackColor = Color.LightBlue;
            B2B_user.BorderStyle = BorderStyle.FixedSingle;
        }

        private void B2B_user_Pic_Leave(object sender, EventArgs e)
        {
            B2B_user.BackColor = SystemColors.ControlLightLight;
            B2B_user.BorderStyle = BorderStyle.None;
        }

        private void B2B_user_Pic_Move(object sender, MouseEventArgs e)
        {
            B2B_user.BackColor = Color.LightBlue;
            B2B_user.BorderStyle = BorderStyle.FixedSingle;
        }

        private void system_user_Pannel_Leave(object sender, EventArgs e)
        {
            system_user.BackColor = SystemColors.ControlLightLight;
            system_user.BorderStyle = BorderStyle.None;
        }

        private void system_user_Pannel_move(object sender, MouseEventArgs e)
        {
            system_user.BackColor = Color.LightBlue;
            system_user.BorderStyle = BorderStyle.FixedSingle;

        }

        private void system_user_Pic_Leave(object sender, EventArgs e)
        {
            system_user.BackColor = SystemColors.ControlLightLight;
            system_user.BorderStyle = BorderStyle.None;
        }

        private void system_user_Pic_Move(object sender, MouseEventArgs e)
        {
            system_user.BackColor = Color.LightBlue;
            system_user.BorderStyle = BorderStyle.FixedSingle;
        }

        private void inv_Pannel_Leave(object sender, EventArgs e)
        {
            inv.BackColor = SystemColors.ControlLightLight;
            inv.BorderStyle = BorderStyle.None;
        }

        private void inv_Pannel_Hover(object sender, MouseEventArgs e)
        {
            inv.BackColor = Color.LightBlue;
            inv.BorderStyle = BorderStyle.FixedSingle;
        }

        private void inv_Pic_Leave(object sender, EventArgs e)
        {
            inv.BackColor = Color.LightBlue;
            inv.BorderStyle = BorderStyle.FixedSingle;
        }

        private void inv_Pic_Hover(object sender, MouseEventArgs e)
        {
            inv.BackColor = SystemColors.ControlLightLight;
            inv.BorderStyle = BorderStyle.None;
        }

        private void b2b_user_system_Pannel_Leave(object sender, EventArgs e)
        {
            b2b_user_system.BackColor = SystemColors.ControlLightLight;
            b2b_user_system.BorderStyle = BorderStyle.None;
        }

        private void b2b_user_system_Pannel_Move(object sender, MouseEventArgs e)
        {
            b2b_user_system.BackColor = Color.LightBlue;
            b2b_user_system.BorderStyle = BorderStyle.FixedSingle;
        }

        private void b2b_user_system_Pic_Leave(object sender, EventArgs e)
        {
            b2b_user_system.BackColor = SystemColors.ControlLightLight;
            b2b_user_system.BorderStyle = BorderStyle.None;
        }
        private void b2b_user_system_Pic_Move(object sender, MouseEventArgs e)
        {
            b2b_user_system.BackColor = Color.LightBlue;
            b2b_user_system.BorderStyle = BorderStyle.FixedSingle;
        }

        private void scan_data_Pannel_leave(object sender, EventArgs e)
        {
            scan_data.BackColor = SystemColors.ControlLightLight;
            scan_data.BorderStyle = BorderStyle.None;
        }

        private void scan_data_Pannel_move(object sender, MouseEventArgs e)
        {
            scan_data.BackColor = Color.LightBlue;
            scan_data.BorderStyle = BorderStyle.FixedSingle;
        }

        private void scan_data_Pic_leave(object sender, EventArgs e)
        {
            scan_data.BackColor = SystemColors.ControlLightLight;
            scan_data.BorderStyle = BorderStyle.None;
        }

        private void scan_data_Pic_move(object sender, MouseEventArgs e)
        {
            scan_data.BackColor = Color.LightBlue;
            scan_data.BorderStyle = BorderStyle.FixedSingle;
        }

        private void new_404user_Pannel_leave(object sender, EventArgs e)
        {
            new_404user.BackColor = SystemColors.ControlLightLight;
            new_404user.BorderStyle = BorderStyle.None;
        }

        private void new_404user_Pannel_hover(object sender, MouseEventArgs e)
        {
            new_404user.BackColor = Color.LightBlue;
            new_404user.BorderStyle = BorderStyle.FixedSingle;
        }

        private void new_404user_Pic_leave(object sender, EventArgs e)
        {
            new_404user.BackColor = SystemColors.ControlLightLight;
            new_404user.BorderStyle = BorderStyle.None;
        }

        private void new_404user_Pic_move(object sender, MouseEventArgs e)
        {
            new_404user.BackColor = Color.LightBlue;
            new_404user.BorderStyle = BorderStyle.FixedSingle;
        }

        private void new_902user_Pannel_leave(object sender, EventArgs e)
        {
            new_902user.BackColor = SystemColors.ControlLightLight;
            new_902user.BorderStyle = BorderStyle.None;
        }

        private void new_902user_Pannel_move(object sender, MouseEventArgs e)
        {
            new_902user.BackColor = Color.LightBlue;
            new_902user.BorderStyle = BorderStyle.FixedSingle;
        }

        private void new_902user_Pic_leave(object sender, EventArgs e)
        {
            new_902user.BackColor = SystemColors.ControlLightLight;
            new_902user.BorderStyle = BorderStyle.None;
        }

        private void new_902user_Pic_move(object sender, MouseEventArgs e)
        {
            new_902user.BackColor = Color.LightBlue;
            new_902user.BorderStyle = BorderStyle.FixedSingle;
        }

    }
}
