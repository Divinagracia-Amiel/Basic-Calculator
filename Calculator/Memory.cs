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

        public void add_mem(Form1 main_form)
        {
            int name = main_form.name;
            int panel_newLoc_multiplier = main_form.panel_newLoc_multiplier;
            Label Mem_objLabel = new Label();
            Panel Mem_obj = new Panel();
            Button btn_MR = new Button();
            Button btn_mAdd = new Button();
            Button btn_mSub = new Button();
            Mem_obj.Name = "panel" + name;
            if (main_form.panel_newLoc_multiplier == 0)
            {
                Mem_obj.Location = new Point(3, 3);
            }
            else
            {
                Mem_obj.Top = panel_newLoc_multiplier * 64;
            }
            Mem_obj.Size = new Size(209, 60);
            main_form.mem_page.Controls.Add(Mem_obj);
            btn_MR.Name = "btn_MR" + name;
            btn_MR.Text = "MR";
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
            Mem_objLabel.Name = "label" + name;
            Mem_objLabel.Text = "69";
            Mem_objLabel.Location = new Point(176, 2);
            Mem_objLabel.Margin = new Padding(3, 0, 3, 0);
            Mem_objLabel.Size = new Size(30, 24);
            Mem_objLabel.Font = new Font("Microsoft Sans Serif", 14);      
            Mem_obj.Controls.AddRange(new Control[] { btn_MR, btn_mAdd, btn_mSub, Mem_objLabel });
            main_form.panel_newLoc_multiplier++;
            main_form.name++;
        }

        public void method(Form1 control)
        {
            
        }
    }
}
