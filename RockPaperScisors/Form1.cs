using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace RockPaperScisors
{
    public partial class Form1 : Form
    {

        public static int startnumb = 4;    //Czas gdzie można wybierać ruch
        public static int waitnumb = 3;     //Czas gdzie pokazany jest wynik
        //public static int picknumb = 2;     //Liczba ile wyborów wstecz program ma zapisywać
        public int numb = startnumb;    //Liczba do wyświetlania czasu
        public bool game = false;   //Zmienna mówiąca czy gra jest w fazie ruchu czy wyniku
        public int pick = 0;    //Przechowuje wybór użytkownika
        public int comppick = 0;    //Przechowuje wybór komputera
        public int lastpick = 0;    //Ostatnia figura wybrana przez użytkownika
        public int llastpick = 0;   //Przedostatnia wybrana figura przez użytkownika
        //public int[] pickTab = new int [picknumb];     //Tablica przechowująca 2 ostatnie wybory użytkownika

        public Form1()
        {
            InitializeComponent();
            timGame.Interval = 1000;

            string path1 = Environment.CurrentDirectory;
            int cs = path1.Length;
            int ks = cs - 26;
            string path2 = path1.Remove(ks);
            path2 = path2 + "Images/" ;
            Console.WriteLine(path2);

            Stop();
            resetBtn.Enabled = false;
        }

        private void rockbtn_Click(object sender, EventArgs e)
        {
            Change("2Rock.png");
            pick = 1;
        }

        private void scissorsbtn_Click(object sender, EventArgs e)
        {
            Change("Scissors.png");
            pick = 2;
        }

        private void paperbtn_Click(object sender, EventArgs e)
        {
            Change("1Paper.png");
            pick = 3;
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void startbtn_Click(object sender, EventArgs e)
        {
            Start();
            
        }

        private void stopbtn_Click(object sender, EventArgs e)
        {
            Stop();
            
        }

        //Funkcja timera sprawdza w jakiej fazie znajduje się gra a następnie zmienia czas
        private void timGame_Tick(object sender, EventArgs e)
        {
            if(game == false)
            {
                
                if (numb < 0)
                {
                    game = true;

                    numb = waitnumb;

                    Resault();
                    BtnEnbFal();
                }

            }
            else
            {
                
                if (numb < 0)
                {
                    game = false;

                    numb = startnumb;

                    Change("x.png", 2);
                    BtnEnbTru();
                }
            }

            lblTime.Text = Convert.ToString(numb);
            numb--;
        }

        //Funkcja przycisku reset 
        private void Reset()
        {
            Start();
            numb = startnumb;
            plaScore.Text = "0";
            compScore.Text = "0";

            pick = 0;
            lastpick = 0;
            llastpick = 0;

            Change("x.png", 2);

            game = false;

        }

        //Funkcja zmienia obraz wyboru użytkownika i komputera
        public void Change(string character, int pr = 1)
        {
            string path1 = Environment.CurrentDirectory;
            int cs = path1.Length;
            int ks = cs - 26;
            string path2 = path1.Remove(ks);
            path2 = path2 + @"Images\" + character;

            if (pr == 1)
            {
                picBox1.Image = Image.FromFile(path2);
            }
            else if (pr == 2)
            {
                picBox1.Image = Image.FromFile(path2);
                picBox2.Image = Image.FromFile(path2);
            }
            else if (pr == 3)
            {
                picBox2.Image = Image.FromFile(path2);
            }

        }

        //Funkcja oceniająca czy użytkonik wybrał jakąś figurę, jeśli nie to pauzuje program
        public void Resault()
        {
            if(pick != 0)
            {
                CompTurn();
                Compare();

            }
            else
            {
                numb = startnumb;
                game = false;
                Stop();
                
            }
        }

        //Funkcja porównująca wynik użytkownika i koputera i od tego dodaje punkt
        private void Compare()
        {
            int pkt = Convert.ToInt32(plaScore.Text);
            int comppkt = Convert.ToInt32(compScore.Text);

            if (pick == 1)
            {
                if(comppick == 2)
                {
                    pkt++;
                }
                else if(comppick == 3)
                {
                    comppkt++;
                }
            }
            else if (pick == 2)
            {
                if (comppick == 3)
                {
                    pkt++;
                }
                else if (comppick == 1)
                {
                    comppkt++;
                }
            }
            else if (pick == 3)
            {
                if (comppick == 1)
                {
                    pkt++;
                }
                else if (comppick == 2)
                {
                    comppkt++;
                }
            }

            plaScore.Text = Convert.ToString(pkt);
            compScore.Text = Convert.ToString(comppkt);

            pick = 0;
            comppick = 0;
        }

        //Funkcja odpowiedzialna za ture komputera gdzie wybiera co zrobić na podstawie wcześniejszych wyborów użytkownika
        public void CompTurn()
        {
            if (llastpick == lastpick && llastpick == pick)
            {
                switch (pick)
                {
                    case 1:
                        Change("1Paper.png", 3);
                        comppick = 3;
                        break;
                    case 2:
                        Change("2Rock.png", 3);
                        comppick = 1;
                        break;
                    case 3:
                        Change("Scissors.png", 3);
                        comppick = 2;
                        break;
                }
            }
            else if(lastpick == pick)
            {
                llastpick = Pick(lastpick);
            }
            else
            {
                lastpick = Pick(pick);
            }
            
        }

        //Funkcja odpowiadająca za zwykłe losowanie komputera
        public int Pick(int choice)
        {
            Random r = new Random();

            int l = r.Next(1, 4);
            comppick = l;

            switch (l)
            {
                case 1:
                    Change("2Rock.png", 3);

                    break;
                case 2:
                    Change("Scissors.png", 3);
                    break;
                case 3:
                    Change("1Paper.png", 3);
                    break;
            }

            return choice;
        }

        //Funkcje BtnEnb są odpowiedzialne za zablokowanie i odblokowanie przycisków wybierających figury
        public void BtnEnbFal()
        {
            rockbtn.Enabled = false;
            scissorsbtn.Enabled = false;
            paperbtn.Enabled = false;
        }

        public void BtnEnbTru()
        {
            rockbtn.Enabled = true;
            scissorsbtn.Enabled = true;
            paperbtn.Enabled = true;
        }

        //Funkcja zatrzymująca działanie aplikacji
        public void Stop()
        {
            BtnEnbFal();

            startbtn.Enabled = true;
            stopbtn.Enabled = false;

            timGame.Enabled = false;
        }

        //Funkcja startująca działanie aplikacji
        private void Start()
        {

            if(game == true && numb == waitnumb)
            {
                game = false;
                numb = startnumb;
            }
            BtnEnbTru();
            Change("x.png", 2);

            startbtn.Enabled = false;
            stopbtn.Enabled = true;
            resetBtn.Enabled = true;

            timGame.Enabled = true;
        }
    }
}
