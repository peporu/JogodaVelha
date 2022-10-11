using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogodaVelha
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private Boolean turnoX = true;
        private Boolean Jogo = true;

        private string btnClicked;
        

        private bool checkTurno(bool x,string y)
        {
            if (turnoX == true && Jogo == true)
            {
                btn7.Text = "X";
                return false;
                labelVitoria.Text = "Turno = X";
            }
            else if (turnoX != true && Jogo == true)
            {
                btn7.Text = "O";
                return true;
                labelVitoria.Text = "Turno = Y";
            }
            return false;
            
        }


        private void btn7_Click(object sender, EventArgs e)
        {
            btnClicked = "btn7";
            
           if (turnoX == true && Jogo == true)
            {
                btn7.Text = "X";
                turnoX = false;
            }
            else if (turnoX != true && Jogo == true)
            {
                btn7.Text = "O";
                turnoX = true;
            }

            if(btn7.Text == btn8.Text && btn7.Text == btn9.Text)
            {
                labelVitoria.Text = btn7.Text + "Venceu";
                Jogo = false;
            }
            else if(btn7.Text == btn4.Text && btn7.Text == btn1.Text)
            {
                labelVitoria.Text = btn7.Text + "Venceu";
                Jogo = false;
            }
            else if(btn7.Text == btn5.Text && btn7.Text == btn3.Text)
            {
                labelVitoria.Text = btn7.Text + "Venceu";
                Jogo = false;
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (turnoX == true && Jogo == true)
            {
                btn8.Text = "X";
                turnoX = false;
            }
            else if (turnoX != true && Jogo == true)
            {
                btn8.Text = "O";
                turnoX = true;
            }

            if (btn8.Text == btn7.Text && btn8.Text == btn9.Text)
            {
                labelVitoria.Text = btn8.Text + "Venceu";
                Jogo = false;
            }
            else if (btn8.Text == btn5.Text && btn8.Text == btn2.Text)
            {
                labelVitoria.Text = btn8.Text + "Venceu";
                Jogo = false;
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (turnoX == true && Jogo == true)
            {
                btn9.Text = "X";
                turnoX = false;
            }
            else if (turnoX != true && Jogo == true)
            {
                btn9.Text = "O";
                turnoX = true;
            }

            if (btn9.Text == btn8.Text && btn9.Text == btn7.Text)
            {
                labelVitoria.Text = btn9.Text + "Venceu";
                Jogo = false;
            }
            else if (btn9.Text == btn6.Text && btn9.Text == btn3.Text)
            {
                labelVitoria.Text = btn9.Text + "Venceu";
                Jogo = false;
            }
            else if (btn9.Text == btn5.Text && btn9.Text == btn1.Text)
            {
                labelVitoria.Text = btn9.Text + "Venceu";
                Jogo = false;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (turnoX == true && Jogo == true)
            {
                btn4.Text = "X";
                turnoX = false;
            }
            else if (turnoX != true && Jogo == true)
            {
                btn4.Text = "O";
                turnoX = true;
            }

            if (btn4.Text == btn5.Text && btn4.Text == btn6.Text)
            {
                labelVitoria.Text = btn4.Text + "Venceu";
                Jogo = false;
            }
            else if (btn4.Text == btn7.Text && btn4.Text == btn1.Text)
            {
                labelVitoria.Text = btn4.Text + "Venceu";
                Jogo = false;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (turnoX == true && Jogo == true)
            {
                btn5.Text = "X";
                turnoX = false;
            }
            else if (turnoX != true && Jogo == true)
            {
                btn5.Text = "O";
                turnoX = true;
            }

            if (btn5.Text == btn4.Text && btn5.Text == btn6.Text)
            {
                labelVitoria.Text = btn5.Text + "Venceu";
                Jogo = false;
            }
            else if (btn5.Text == btn2.Text && btn5.Text == btn8.Text)
            {
                labelVitoria.Text = btn5.Text + "Venceu";
                Jogo = false;
            }
           
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (turnoX == true && Jogo == true)
            {
                btn6.Text = "X";
                turnoX = false;
            }
            else if (turnoX != true && Jogo == true)
            {
                btn6.Text = "O";
                turnoX = true;
            }

            if (btn6.Text == btn9.Text && btn6.Text == btn3.Text)
            {
                labelVitoria.Text = btn6.Text + "Venceu";
                Jogo = false;
            }
            else if (btn6.Text == btn5.Text && btn6.Text == btn4.Text)
            {
                labelVitoria.Text = btn6.Text + "Venceu";
                Jogo = false;
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (turnoX == true && Jogo == true)
            {
                btn1.Text = "X";
                turnoX = false;
            }
            else if (turnoX != true && Jogo == true)
            {
                btn1.Text = "O";
                turnoX = true;
            }

            if (btn1.Text == btn4.Text && btn1.Text == btn7.Text)
            {
                labelVitoria.Text = btn1.Text + "Venceu";
                Jogo = false;
            }
            else if (btn1.Text == btn5.Text && btn1.Text == btn9.Text)
            {
                labelVitoria.Text = btn1.Text + "Venceu";
                Jogo = false;
            }
            else if (btn1.Text == btn2.Text && btn1.Text == btn3.Text)
            {
                labelVitoria.Text = this.Text + "Venceu";
                Jogo = false;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (turnoX == true && Jogo == true)
            {
                btn2.Text = "X";
                turnoX = false;
            }
            else if (turnoX != true && Jogo == true)
            {
                btn2.Text = "O";
                turnoX = true;
            }

            if (btn2.Text == btn5.Text && btn2.Text == btn8.Text)
            {
                labelVitoria.Text = btn2.Text + "Venceu";
                Jogo = false;
            }
            else if (btn2.Text == btn1.Text && btn2.Text == btn3.Text)
            {
                labelVitoria.Text = btn2.Text + "Venceu";
                Jogo = false;
            }
            
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (turnoX == true && Jogo == true)
            {
                btn3.Text = "X";
                turnoX = false;
            }
            else if (turnoX != true && Jogo == true)
            {
                btn3.Text = "O";
                turnoX = true;
            }

            if (btn3.Text == btn5.Text && btn3.Text == btn7.Text)
            {
                labelVitoria.Text = btn3.Text + "Venceu";
                Jogo = false;
            }
            else if (btn3.Text == btn2.Text && btn3.Text == btn1.Text)
            {
                labelVitoria.Text = btn3.Text + "Venceu";
                Jogo = false;
            }
            else if (btn3.Text == btn6.Text && btn3.Text == btn9.Text)
            {
                labelVitoria.Text = btn3.Text + "Venceu";
                Jogo = false;
            }
        }

        private void labelVitoria_Click(object sender, EventArgs e)
        {

        }
    }
}
