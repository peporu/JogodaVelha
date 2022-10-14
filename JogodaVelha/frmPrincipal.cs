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
        private int nTurnos = 0;

        private string btnClicked;

        private Boolean turnoMaquina = false;
        private string randomButtonString;


        private void checkTurno(string nome)
        {
            Button btn = this.Controls.Find(nome, false).FirstOrDefault() as Button;
            if (turnoX == true && Jogo == true)
            {
                btn.Text = "X";
                turnoX = false;
                labelTurno.Text = "Turno = O";
                nTurnos++;
            }
            else if (turnoX != true && Jogo == true)
            {
                btn.Text = "O";
                turnoX = true;
                labelTurno.Text = "Turno = X";
                nTurnos++;
            }
        }

        private void checkWin()
        {
            if (btn7.Text == btn8.Text && btn7.Text == btn9.Text && btn7.Text != "") //linha um
            {
                labelVitoria.Text = "Vencedor = " + btn7.Text;
                Jogo = false;
            }
            else if (btn7.Text == btn4.Text && btn7.Text == btn1.Text && btn7.Text != "") //coluna um
            {
                labelVitoria.Text = "Vencedor = " + btn7.Text;
                Jogo = false;
            }
            else if (btn5.Text == btn7.Text && btn5.Text == btn3.Text && btn5.Text != "") // Diagonal 7 a 3
            {
                labelVitoria.Text = "Vencedor = " + btn5.Text;
                Jogo = false;
            }
            else if (btn5.Text == btn1.Text && btn5.Text == btn9.Text && btn5.Text != "") // Diagonal 1 a 9
            {
                labelVitoria.Text = "Vencedor = " + btn5.Text;
                Jogo = false;
            }
            else if (btn5.Text == btn4.Text && btn5.Text == btn6.Text && btn5.Text != "") // linha dois
            {
                labelVitoria.Text = "Vencedor = " + btn5.Text;
                Jogo = false;
            }
            else if (btn5.Text == btn8.Text && btn5.Text == btn2.Text && btn5.Text != "") //coluna dois
            {
                labelVitoria.Text = "Vencedor = " + btn5.Text;
                Jogo = false;
            }
            else if (btn3.Text == btn6.Text && btn3.Text == btn9.Text && btn3.Text != "") //coluna 3
            {
                labelVitoria.Text = "Vencedor = " + btn3.Text;
                Jogo = false;
            }
            else if (btn3.Text == btn2.Text && btn3.Text == btn1.Text && btn3.Text != "") //linha 3
            {
                labelVitoria.Text = "Vencedor = " + btn3.Text;
                Jogo = false;
            }
            else if (nTurnos == 9)
            {
                labelVitoria.Text = "Deu Velha!";
            }

        }

        private void turnoDoPC()
        {

            Boolean validade = false;
            while (validade == false)
            {
                Random rd = new Random();   //inicia um objeto random
                int randomButton = rd.Next(1, 9); // da o valor de 1 a 9 para uma int usando o objeto random
                randomButtonString = "btn" + Convert.ToString(randomButton); //cria o nome do botão a partir do numero randomizado
                Button btn = this.Controls.Find(randomButtonString, false).FirstOrDefault() as Button;
                if (btn.Text == "")
                {
                    validade = true;
                }
                else if (nTurnos == 8 || nTurnos == 9)
                {
                    return;
                }

            }
            if (nTurnos < 8)
            {
                checkTurno(randomButtonString);
            }
            else { return; }
        }

        private void restartGame()
        {
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";

            labelVitoria.Text = "Jogo";

            Jogo = true;
            nTurnos = 0;
            turnoX = true;
        }



        private void btn7_Click(object sender, EventArgs e)
        {
            btnClicked = "btn7";
            if (btn7.Text == "")
            {
                checkTurno(btnClicked);
                checkWin();
                if (turnoMaquina == true)
                {
                    turnoDoPC();
                }

            }


            checkWin();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            btnClicked = "btn8";
            if (btn8.Text == "")
            {
                checkTurno(btnClicked);
                checkWin();

                if (turnoMaquina == true)
                {
                    turnoDoPC();
                }
            }

            checkWin();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            btnClicked = "btn9";
            if (btn9.Text == "")
            {
                checkTurno(btnClicked);
                checkWin();

                if (turnoMaquina == true)
                {
                    turnoDoPC();
                }
            }


            checkWin();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            btnClicked = "btn4";
            if (btn4.Text == "")
            {
                checkTurno(btnClicked);
                checkWin();

                if (turnoMaquina == true)
                {
                    turnoDoPC();
                }
            }


            checkWin();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            btnClicked = "btn5";
            if (btn5.Text == "")
            {
                checkTurno(btnClicked);
                checkWin();
                if (turnoMaquina == true)
                {
                    turnoDoPC();
                }
            }



            checkWin();

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            btnClicked = "btn6";
            if (btn6.Text == "")
            {
                checkTurno(btnClicked);
                checkWin();
                if (turnoMaquina == true)
                {
                    turnoDoPC();
                }
            }



            checkWin();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            btnClicked = "btn1";
            if (btn1.Text == "")
            {
                checkTurno(btnClicked);
                checkWin();
                if (turnoMaquina == true)
                {
                    turnoDoPC();
                }
            }


            checkWin();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            btnClicked = "btn2";
            if (btn2.Text == "")
            {
                checkTurno(btnClicked);
                checkWin();
                if (turnoMaquina == true)
                {
                    turnoDoPC();
                }
            }


            checkWin();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            btnClicked = "btn3";
            if (btn3.Text == "")
            {
                checkTurno(btnClicked);
                checkWin();
                if (turnoMaquina == true)
                {
                    turnoDoPC();
                }
            }


            checkWin();
        }

        private void labelVitoria_Click(object sender, EventArgs e)
        {

        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            restartGame();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            turnoMaquina = !turnoMaquina;
            restartGame();

        }
    }
}
