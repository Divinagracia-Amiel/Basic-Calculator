using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Calculator
{
    public class Memory 
    {      
        double n;
        double n_2;
        private double res;
        private int last_control;
        private string removedPanelIndexName;
        private int removedPanelIndex;
        public void add_mem(Form1 main_form)
        {
            res = 0;
            int name = main_form.name;
            int panel_newLoc_multiplier = main_form.panel_newLoc_multiplier;
            RichTextBox Mem_objtxtbox = new RichTextBox();
            Panel Mem_obj = new Panel();
            Button btn_MR = new Button();
            Button btn_mAdd = new Button();
            Button btn_mSub = new Button();
            Mem_obj.Name = "panel" + name;
            Mem_obj.Location = new Point(3, 3);
            Mem_obj.Size = new Size(209, 60);
            Mem_obj.MouseHover += (obj, eArgs) =>
            {
                Mem_obj.BackColor = Color.DarkGray;
                btn_MR.BackColor = Control.DefaultBackColor;
                btn_mSub.BackColor = Control.DefaultBackColor;
                btn_mAdd.BackColor = Control.DefaultBackColor;
            };
            Mem_obj.MouseLeave += (obj, eArgs) =>
            {
                Mem_obj.BackColor = Color.Transparent;
                btn_MR.BackColor = Control.DefaultBackColor;
                btn_mSub.BackColor = Control.DefaultBackColor;
                btn_mAdd.BackColor = Control.DefaultBackColor;
            };
            Mem_obj.DoubleClick += (obj, eArgs) =>
            {
                main_form.ioScreen.Text = Mem_obj.Controls[3].Text;
            };
            if (main_form.mem_page.Controls.Count > 0)
            {
                last_control = main_form.mem_page.Controls.Count;
                for (int i = 0; i <= last_control - 1; i++)
                {
                    main_form.mem_page.Controls[i].Top += 64;
                }
            }
            main_form.mem_page.Controls.Add(Mem_obj);                 
            btn_MR.Name = "btn_MC" + name;
            btn_MR.Text = "MC";
            btn_MR.Location = new Point(64, 29);
            btn_MR.Margin = new Padding(1, 1, 1, 1);
            btn_MR.Size = new Size(46, 31);
            btn_mAdd.Name = "btn_mADD" + name;
            btn_mAdd.Text = "M+";
            btn_mAdd.Location = new Point(112, 29);
            btn_mAdd.Margin = new Padding(1, 1, 1, 1);
            btn_mAdd.Size = new Size(46, 31);
            btn_mSub.Name = "btn_mSub" + name;
            btn_mSub.Text = "M-";
            btn_mSub.Location = new Point(160, 29);
            btn_mSub.Margin = new Padding(1, 1, 1, 1);
            btn_mSub.Size = new Size(46, 31);
            Mem_objtxtbox.Name = "label" + name;
            Mem_objtxtbox.Location = new Point(3, 2);
            Mem_objtxtbox.SelectAll();
            Mem_objtxtbox.SelectionAlignment = HorizontalAlignment.Right;
            Mem_objtxtbox.Margin = new Padding(3, 0, 3, 0);
            Mem_objtxtbox.Size = new Size(203, 24);
            Mem_objtxtbox.Text = main_form.ioScreen.Text;
            Mem_objtxtbox.Font = new Font("Microsoft Sans Serif", 14);
            btn_MR.Click += (obj, eArgs) =>
            {
                removedPanelIndexName = Mem_obj.Name;
                for (int i = 0; i < main_form.mem_page.Controls.Count; i++)
                {
                    if (main_form.mem_page.Controls[i].Name == removedPanelIndexName)
                    {
                        break;
                    }
                    removedPanelIndex++;
                }
                main_form.mem_page.Controls.Remove(main_form.mem_page.Controls[removedPanelIndex]);
                for (int i = 0; i < removedPanelIndex; i++)
                {
                    main_form.mem_page.Controls[i].Top -= 64;
                }          
            };
            btn_mAdd.Click += (obj, eArgs) =>
            {
                n = double.Parse(main_form.ioScreen.Text);
                n_2 = double.Parse(Mem_objtxtbox.Text);              
                res = n + n_2;
                Mem_objtxtbox.Text = res.ToString();
            };
            btn_mSub.Click += (obs, eArgs) =>
            {
                n = double.Parse(main_form.ioScreen.Text);
                n_2 = double.Parse(Mem_objtxtbox.Text);
                res = n_2 - n;
                Mem_objtxtbox.Text = res.ToString();
            };
            Mem_obj.Controls.AddRange(new Control[] { btn_MR, btn_mAdd, btn_mSub, Mem_objtxtbox });
            main_form.panelVal = Mem_objtxtbox;
            main_form.panel_newLoc_multiplier++;
            main_form.name++;
        }
    }
}
