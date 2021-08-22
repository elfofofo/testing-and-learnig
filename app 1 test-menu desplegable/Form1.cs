using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_1_test_menu_desplegable
{
    public partial class Pan_cabecera : Form
    {
      

        public Pan_cabecera()
        {
           

            InitializeComponent();//pocicionando los botones 
            Btn2.Location = new Point(Btn1.Location.X, Btn1.Location.Y + Btn1.Height);
            //pocicionando paneles con los botones
            PanelSubBtn1.Location = new Point(Btn1.Location.X, Btn1.Location.Y + Btn1.Height);
            Pnl2.Location = new Point(Btn2.Location.X, Btn2.Location.Y + Btn2.Height);
        }
          
        private void button2_Click(object sender, EventArgs e)
        {
            PanelSubBtn1.Visible = !PanelSubBtn1.Visible;
            if (PanelSubBtn1.Visible == true)
            {

                // ajustanto pocicion de botton2  en caso de activarlo
                Btn2.Location = new Point(Btn1.Location.X, Btn1.Location.Y + Btn1.Height + PanelSubBtn1.Height);
           


            }
            else 
            {    //ajustando pocicion de  panel en caso de 
                Btn2.Location = new Point(Btn1.Location.X, Btn1.Location.Y + Btn1.Height);
               
            }// ajustando panel a la nuevaa pocicion del botton 
            Pnl2.Location = new Point(Btn2.Location.X, Btn2.Location.Y + Btn2.Height);
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            Pnl2.Visible = !Pnl2.Visible;
            if (PanelSubBtn1.Visible == true) {
                Btn2.Location = new Point(Btn1.Location.X, Btn1.Location.Y + Btn1.Height+PanelSubBtn1.Height);
            }
            else { }
        }
    }
}
