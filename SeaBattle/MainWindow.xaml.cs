﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace SeaBattle
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();
        }

        public int playerShips = 0;
        public int enemyShips = 0;
        public bool gameStart = false;

        /// //////////////////////////////////////////////////////////////////////////
        /// Check Functions
        //////////////////////////////////////////////////////////////////////////////
        bool CheckGameStart()
        {
            return gameStart;
        }

        bool CheckCountToStart()
        {
            if (playerShips == 7 && gameStart == false)
            {
                gameStart = true;
                SelectByEnemy();
                SelectByEnemy();
                SelectByEnemy();
                SelectByEnemy();
                SelectByEnemy();
                SelectByEnemy();
                SelectByEnemy();
                AttackByEnemy();
            }
            return gameStart;
        }

        void CheckCountToWin()
        {
            if (gameStart == true)
            {
                if (playerShips == 0)
                {
                    Content = "You are loser!";
                }
                else if (enemyShips == 0)
                {
                    Content = "You are winner!";
                }
            }
        }



        /// //////////////////////////////////////////////////////////////////////////
        /// Enemy Attack
        //////////////////////////////////////////////////////////////////////////////
        void AttackByEnemy()
        {
            Random ran = new Random();
            int value = ran.Next(0, 24);
            if (value == 0)
            {
                if (Convert.ToString(a0a0.Content) == ".")
                {
                    a0a0.Content = "Miss!";
                    a0a0.FontSize = 25;
                    a0a0.Foreground = Brushes.Red;
                }
                else if (Convert.ToString(a0a0.Content) == "-")
                {
                    a0a0.Content = "X"; playerShips -= 1;
                    a0a0.FontSize = 50;
                    a0a0.Foreground = Brushes.Red;
                    CheckCountToWin();
                }
                else
                {
                    AttackByEnemy();
                }
            }

            if (value == 1)
            {
                if (Convert.ToString(a0a1.Content) == ".")
                {
                    a0a1.Content = "Miss!";
                    a0a1.FontSize = 25;
                    a0a1.Foreground = Brushes.Red;
                }
                else if (Convert.ToString(a0a1.Content) == "-")
                {
                    a0a1.Content = "X"; playerShips -= 1;
                    a0a1.FontSize = 50;
                    a0a1.Foreground = Brushes.Red;
                    CheckCountToWin();
                }
                else
                {
                    AttackByEnemy();
                }
            }

            if (value == 2)
            {
                if (Convert.ToString(a0a2.Content) == ".")
                {
                    a0a2.Content = "Miss!";
                    a0a2.FontSize = 25;
                    a0a2.Foreground = Brushes.Red;
                }
                else if (Convert.ToString(a0a2.Content) == "-")
                {
                    a0a2.Content = "X"; playerShips -= 1;
                    a0a2.FontSize = 50;
                    a0a2.Foreground = Brushes.Red;
                    CheckCountToWin();
                }
                else
                {
                    AttackByEnemy();
                }
            }

            if (value == 3)
            {
                if (Convert.ToString(a0a3.Content) == ".")
                {
                    a0a3.Content = "Miss!";
                    a0a3.FontSize = 25;
                    a0a3.Foreground = Brushes.Red;
                }
                else if (Convert.ToString(a0a3.Content) == "-")
                {
                    a0a3.Content = "X"; playerShips -= 1;
                    a0a3.FontSize = 50;
                    a0a3.Foreground = Brushes.Red;
                    CheckCountToWin();
                }
                else
                {
                    AttackByEnemy();
                }
            }

            if (value == 4)
            {
                if (Convert.ToString(a0a4.Content) == ".")
                {
                    a0a4.Content = "Miss!";
                    a0a4.FontSize = 25;
                    a0a4.Foreground = Brushes.Red;
                }
                else if (Convert.ToString(a0a4.Content) == "-")
                {
                    a0a4.Content = "X"; playerShips -= 1;
                    a0a4.FontSize = 50;
                    a0a4.Foreground = Brushes.Red;
                    CheckCountToWin();
                }
                else
                {
                    AttackByEnemy();
                }
            }
            //////////////////////////////////////////////////////////////////////////

            if (value == 5)
            {
                if (Convert.ToString(a1a0.Content) == ".")
                {
                    a1a0.Content = "Miss!";
                    a1a0.FontSize = 25;
                    a1a0.Foreground = Brushes.Red;
                }
                else if (Convert.ToString(a1a0.Content) == "-")
                {
                    a1a0.Content = "X"; playerShips -= 1;
                    a1a0.FontSize = 50;
                    a1a0.Foreground = Brushes.Red;
                    CheckCountToWin();
                }
                else
                {
                    AttackByEnemy();
                }
            }

            if (value == 6)
            {
                if (Convert.ToString(a1a1.Content) == ".")
                {
                    a1a1.Content = "Miss!";
                    a1a1.FontSize = 25;
                    a1a1.Foreground = Brushes.Red;
                }
                else if (Convert.ToString(a1a1.Content) == "-")
                {
                    a1a1.Content = "X"; playerShips -= 1;
                    a1a1.FontSize = 50;
                    a1a1.Foreground = Brushes.Red;
                    CheckCountToWin();
                }
                else
                {
                    AttackByEnemy();
                }
            }

            if (value == 7)
            {
                if (Convert.ToString(a1a2.Content) == ".")
                {
                    a1a2.Content = "Miss!";
                    a1a2.FontSize = 25;
                    a1a2.Foreground = Brushes.Red;
                }
                else if (Convert.ToString(a1a2.Content) == "-")
                {
                    a1a2.Content = "X"; playerShips -= 1;
                    a1a2.FontSize = 50;
                    a1a2.Foreground = Brushes.Red;
                    CheckCountToWin();
                }
                else
                {
                    AttackByEnemy();
                }
            }

            if (value == 8)
            {
                if (Convert.ToString(a1a3.Content) == ".")
                {
                    a1a3.Content = "Miss!";
                    a1a3.FontSize = 25;
                    a1a3.Foreground = Brushes.Red;
                }
                else if (Convert.ToString(a1a3.Content) == "-")
                {
                    a1a3.Content = "X"; playerShips -= 1;
                    a1a3.FontSize = 50;
                    a1a3.Foreground = Brushes.Red;
                    CheckCountToWin();
                }
                else
                {
                    AttackByEnemy();
                }
            }

            if (value == 9)
            {
                if (Convert.ToString(a1a4.Content) == ".")
                {
                    a1a4.Content = "Miss!";
                    a1a4.FontSize = 25;
                    a1a4.Foreground = Brushes.Red;
                }
                else if (Convert.ToString(a1a4.Content) == "-")
                {
                    a1a4.Content = "X"; playerShips -= 1;
                    a1a4.FontSize = 50;
                    a1a4.Foreground = Brushes.Red;
                    CheckCountToWin();
                }
                else
                {
                    AttackByEnemy();
                }
            }
            /////////////////////////////////////////////////////////////////

            if (value == 10)
            {
                if (Convert.ToString(a2a0.Content) == ".")
                {
                    a2a0.Content = "Miss!";
                    a2a0.FontSize = 25;
                    a2a0.Foreground = Brushes.Red;
                }
                else if (Convert.ToString(a2a0.Content) == "-")
                {
                    a2a0.Content = "X"; playerShips -= 1;
                    a2a0.FontSize = 50;
                    a2a0.Foreground = Brushes.Red;
                    CheckCountToWin();
                }
                else
                {
                    AttackByEnemy();
                }
            }

            if (value == 11)
            {
                if (Convert.ToString(a2a1.Content) == ".")
                {
                    a2a1.Content = "Miss!";
                    a2a1.FontSize = 25;
                    a2a1.Foreground = Brushes.Red;
                }
                else if (Convert.ToString(a2a1.Content) == "-")
                {
                    a2a1.Content = "X"; playerShips -= 1;
                    a2a1.FontSize = 50;
                    a2a1.Foreground = Brushes.Red;
                    CheckCountToWin();
                }
                else
                {
                    AttackByEnemy();
                }
            }

            if (value == 12)
            {
                if (Convert.ToString(a2a2.Content) == ".")
                {
                    a2a2.Content = "Miss!";
                    a2a2.FontSize = 25;
                    a2a2.Foreground = Brushes.Red;
                }
                else if (Convert.ToString(a2a2.Content) == "-")
                {
                    a2a2.Content = "X"; playerShips -= 1;
                    a2a2.FontSize = 50;
                    a2a2.Foreground = Brushes.Red;
                    CheckCountToWin();
                }
                else
                {
                    AttackByEnemy();
                }
            }

            if (value == 13)
            {
                if (Convert.ToString(a2a3.Content) == ".")
                {
                    a2a3.Content = "Miss!";
                    a2a3.FontSize = 25;
                    a2a3.Foreground = Brushes.Red;
                }
                else if (Convert.ToString(a2a3.Content) == "-")
                {
                    a2a3.Content = "X"; playerShips -= 1;
                    a2a3.FontSize = 50;
                    a2a3.Foreground = Brushes.Red;
                    CheckCountToWin();
                }
                else
                {
                    AttackByEnemy();
                }
            }

            if (value == 14)
            {
                if (Convert.ToString(a2a4.Content) == ".")
                {
                    a2a4.Content = "Miss!";
                    a2a4.FontSize = 25;
                    a2a4.Foreground = Brushes.Red;
                }
                else if (Convert.ToString(a2a4.Content) == "-")
                {
                    a2a4.Content = "X"; playerShips -= 1;
                    a2a4.FontSize = 50;
                    a2a4.Foreground = Brushes.Red;
                    CheckCountToWin();
                }
                else
                {
                    AttackByEnemy();
                }
            }
            /////////////////////////////////////////////////////////////////

            if (value == 15)
            {
                if (Convert.ToString(a3a0.Content) == ".")
                {
                    a3a0.Content = "Miss!";
                    a3a0.FontSize = 25;
                    a3a0.Foreground = Brushes.Red;
                }
                else if (Convert.ToString(a3a0.Content) == "-")
                {
                    a3a0.Content = "X"; playerShips -= 1;
                    a3a0.FontSize = 50;
                    a3a0.Foreground = Brushes.Red;
                    CheckCountToWin();
                }
                else
                {
                    AttackByEnemy();
                }
            }

            if (value == 16)
            {
                if (Convert.ToString(a3a1.Content) == ".")
                {
                    a3a1.Content = "Miss!";
                    a3a1.FontSize = 25;
                    a3a1.Foreground = Brushes.Red;
                }
                else if (Convert.ToString(a3a1.Content) == "-")
                {
                    a3a1.Content = "X"; playerShips -= 1;
                    a3a1.FontSize = 50;
                    a3a1.Foreground = Brushes.Red;
                    CheckCountToWin();
                }
                else
                {
                    AttackByEnemy();
                }
            }

            if (value == 17)
            {
                if (Convert.ToString(a3a2.Content) == ".")
                {
                    a3a2.Content = "Miss!";
                    a3a2.FontSize = 25;
                    a3a2.Foreground = Brushes.Red;
                }
                else if (Convert.ToString(a3a2.Content) == "-")
                {
                    a3a2.Content = "X"; playerShips -= 1;
                    a3a2.FontSize = 50;
                    a3a2.Foreground = Brushes.Red;
                    CheckCountToWin();
                }
                else
                {
                    AttackByEnemy();
                }
            }

            if (value == 18)
            {
                if (Convert.ToString(a3a3.Content) == ".")
                {
                    a3a3.Content = "Miss!";
                    a3a3.FontSize = 25;
                    a3a3.Foreground = Brushes.Red;
                }
                else if (Convert.ToString(a3a3.Content) == "-")
                {
                    a3a3.Content = "X"; playerShips -= 1;
                    a3a3.FontSize = 50;
                    a3a3.Foreground = Brushes.Red;
                    CheckCountToWin();
                }
                else
                {
                    AttackByEnemy();
                }
            }

            if (value == 19)
            {
                if (Convert.ToString(a3a4.Content) == ".")
                {
                    a3a4.Content = "Miss!";
                    a3a4.FontSize = 25;
                    a3a4.Foreground = Brushes.Red;
                }
                else if (Convert.ToString(a3a4.Content) == "-")
                {
                    a3a4.Content = "X"; playerShips -= 1;
                    a3a4.FontSize = 50;
                    a3a4.Foreground = Brushes.Red;
                    CheckCountToWin();
                }
                else
                {
                    AttackByEnemy();
                }
            }
            /////////////////////////////////////////////////////////////////

            if (value == 20)
            {
                if (Convert.ToString(a4a0.Content) == ".")
                {
                    a4a0.Content = "Miss!";
                    a4a0.FontSize = 25;
                    a4a0.Foreground = Brushes.Red;
                }
                else if (Convert.ToString(a4a0.Content) == "-")
                {
                    a4a0.Content = "X"; playerShips -= 1;
                    a4a0.FontSize = 50;
                    a4a0.Foreground = Brushes.Red;
                    CheckCountToWin();
                }
                else
                {
                    AttackByEnemy();
                }
            }

            if (value == 21)
            {
                if (Convert.ToString(a4a1.Content) == ".")
                {
                    a4a1.Content = "Miss!";
                    a4a1.FontSize = 25;
                    a4a1.Foreground = Brushes.Red;
                }
                else if (Convert.ToString(a4a1.Content) == "-")
                {
                    a4a1.Content = "X"; playerShips -= 1;
                    a4a1.FontSize = 50;
                    a4a1.Foreground = Brushes.Red;
                    CheckCountToWin();
                }
                else
                {
                    AttackByEnemy();
                }
            }

            if (value == 22)
            {
                if (Convert.ToString(a4a2.Content) == ".")
                {
                    a4a2.Content = "Miss!";
                    a4a2.FontSize = 25;
                    a4a2.Foreground = Brushes.Red;
                }
                else if (Convert.ToString(a4a2.Content) == "-")
                {
                    a4a2.Content = "X"; playerShips -= 1;
                    a4a2.FontSize = 50;
                    a4a2.Foreground = Brushes.Red;
                    CheckCountToWin();
                }
                else
                {
                    AttackByEnemy();
                }
            }

            if (value == 23)
            {
                if (Convert.ToString(a4a3.Content) == ".")
                {
                    a4a3.Content = "Miss!";
                    a4a3.FontSize = 25;
                    a4a3.Foreground = Brushes.Red;
                }
                else if (Convert.ToString(a4a3.Content) == "-")
                {
                    a4a3.Content = "X"; playerShips -= 1;
                    a4a3.FontSize = 50;
                    a4a3.Foreground = Brushes.Red;
                    CheckCountToWin();
                }
                else
                {
                    AttackByEnemy();
                }
            }

            if (value == 24)
            {
                if (Convert.ToString(a4a4.Content) == ".")
                {
                    a4a4.Content = "Miss!";
                    a4a4.FontSize = 25;
                    a4a4.Foreground = Brushes.Red;
                }
                else if (Convert.ToString(a4a4.Content) == "-")
                {
                    a4a4.Content = "X"; playerShips -= 1;
                    a4a4.FontSize = 50;
                    a4a4.Foreground = Brushes.Red;
                    CheckCountToWin();
                }
                else
                {
                    AttackByEnemy();
                }
            }
        }


        ////////////////////////////////////////////////////////////////
        /// Enemy Select
        /////////////////////////////////////////////////////////////////////
        
        void SelectByEnemy()
        {
            Random ran = new Random();
            int value = ran.Next(50, 74);

            if (value == 50 && enemyShips >= 7)
            {
                if (Convert.ToString(b5b0.Content) == ".")
                {
                    b5b0.Content = "-";
                    enemyShips += 1;
                }

                else if (Convert.ToString(b5b0.Content) == "-")
                {
                    SelectByEnemy();
                }
            }

            if (Convert.ToString(b5b1.Content) == "." && value == 51 && enemyShips < 7)
            {
                b5b1.Content = "-";
                enemyShips += 1;
            }
            else if (Convert.ToString(b5b1.Content) == "-" && value == 51 && enemyShips < 7)
            {
                SelectByEnemy();
            }

            if (Convert.ToString(b5b2.Content) == "." && value == 52 && enemyShips < 7)
            {
                b5b2.Content = "-";
                enemyShips += 1;
            }
            else if (Convert.ToString(b5b2.Content) == "-" && value == 52 && enemyShips < 7)
            {
                SelectByEnemy();
            }

            if (Convert.ToString(b5b3.Content) == "." && value == 53 && enemyShips < 7)
            {
                b5b3.Content = "-";
                enemyShips += 1;
            }
            else if (Convert.ToString(b5b3.Content) == "-" && value == 53 && enemyShips < 7)
            {
                SelectByEnemy();
            }

            if (Convert.ToString(b5b4.Content) == "." && value == 54 && enemyShips < 7)
            {
                b5b4.Content = "-";
                enemyShips += 1;
            }
            else if (Convert.ToString(b5b4.Content) == "-" && value == 54 && enemyShips < 7)
            {
                SelectByEnemy();
            }
            /////////////////////////////////////////////

            if (Convert.ToString(b6b0.Content) == "." && value == 55 && enemyShips < 7)
            {
                b6b0.Content = "-";
                enemyShips += 1;
            }
            else if (Convert.ToString(b6b0.Content) == "-" && value == 55 && enemyShips < 7)
            {
                SelectByEnemy();
            }

            if (Convert.ToString(b6b1.Content) == "." && value == 56 && enemyShips < 7)
            {
                b6b1.Content = "-";
                enemyShips += 1;
            }
            else if (Convert.ToString(b6b1.Content) == "-" && value == 56 && enemyShips < 7)
            {
                SelectByEnemy();
            }

            if (Convert.ToString(b6b2.Content) == "." && value == 57 && enemyShips < 7)
            {
                b6b2.Content = "-";
                enemyShips += 1;
            }
            else if (Convert.ToString(b6b2.Content) == "-" && value == 57 && enemyShips < 7)
            {
                SelectByEnemy();
            }

            if (Convert.ToString(b6b3.Content) == "." && value == 58 && enemyShips < 7)
            {
                b6b3.Content = "-";
                enemyShips += 1;
            }
            else if (Convert.ToString(b6b3.Content) == "-" && value == 58 && enemyShips < 7)
            {
                SelectByEnemy();
            }

            if (Convert.ToString(b6b4.Content) == "." && value == 59 && enemyShips < 7)
            {
                b6b4.Content = "-";
                enemyShips += 1;
            }
            else if (Convert.ToString(b6b4.Content) == "-" && value == 59 && enemyShips < 7)
            {
                SelectByEnemy();
            }
            ////////////////////////////////////////////////////

            if (Convert.ToString(b7b0.Content) == "." && value == 60 && enemyShips < 7)
            {
                b7b0.Content = "-";
                enemyShips += 1;
            }
            else if (Convert.ToString(b7b0.Content) == "-" && value == 60 && enemyShips < 7)
            {
                SelectByEnemy();
            }

            if (Convert.ToString(b7b1.Content) == "." && value == 61 && enemyShips < 7)
            {
                b7b1.Content = "-";
                enemyShips += 1;
            }
            else if (Convert.ToString(b7b1.Content) == "-" && value == 61 && enemyShips < 7)
            {
                SelectByEnemy();
            }

            if (Convert.ToString(b7b2.Content) == "." && value == 62 && enemyShips < 7)
            {
                b7b2.Content = "-";
                enemyShips += 1;
            }
            else if (Convert.ToString(b7b2.Content) == "-" && value == 62 && enemyShips < 7)
            {
                SelectByEnemy();
            }

            if (Convert.ToString(b7b3.Content) == "." && value == 63 && enemyShips < 7)
            {
                b7b3.Content = "-";
                enemyShips += 1;
            }
            else if (Convert.ToString(b7b3.Content) == "-" && value == 63 && enemyShips < 7)
            {
                SelectByEnemy();
            }

            if (Convert.ToString(b7b4.Content) == "." && value == 64 && enemyShips < 7)
            {
                b7b4.Content = "-";
                enemyShips += 1;
            }
            else if (Convert.ToString(b7b4.Content) == "-" && value == 64 && enemyShips < 7)
            {
                SelectByEnemy();
            }
            ///////////////////////////////////////////////////////

            if (Convert.ToString(b8b0.Content) == "." && value == 65 && enemyShips < 7)
            {
                b8b0.Content = "-";
                enemyShips += 1;
            }
            else if (Convert.ToString(b8b0.Content) == "-" && value == 65 && enemyShips < 7)
            {
                SelectByEnemy();
            }

            if (Convert.ToString(b8b1.Content) == "." && value == 66 && enemyShips < 7)
            {
                b8b1.Content = "-";
                enemyShips += 1;
            }
            else if (Convert.ToString(b8b1.Content) == "-" && value == 66 && enemyShips < 7)
            {
                SelectByEnemy();
            }

            if (Convert.ToString(b8b2.Content) == "." && value == 67 && enemyShips < 7)
            {
                b8b2.Content = "-";
                enemyShips += 1;
            }
            else if (Convert.ToString(b8b2.Content) == "-" && value == 67 && enemyShips < 7)
            {
                SelectByEnemy();
            }

            if (Convert.ToString(b8b3.Content) == "." && value == 68 && enemyShips < 7)
            {
                b8b3.Content = "-";
                enemyShips += 1;
            }
            else if (Convert.ToString(b8b3.Content) == "-" && value == 68 && enemyShips < 7)
            {
                SelectByEnemy();
            }

            if (Convert.ToString(b8b4.Content) == "." && value == 69 && enemyShips < 7)
            {
                b8b4.Content = "-";
                enemyShips += 1;
            }
            else if (Convert.ToString(b8b4.Content) == "-" && value == 69 && enemyShips < 7)
            {
                SelectByEnemy();
            }
            /////////////////////////////////////////////

            if (Convert.ToString(b9b0.Content) == "." && value == 70 && enemyShips < 7)
            {
                b9b0.Content = "-";
                enemyShips += 1;
            }
            else if (Convert.ToString(b9b0.Content) == "-" && value == 70 && enemyShips < 7)
            {
                SelectByEnemy();
            }

            if (Convert.ToString(b9b1.Content) == "." && value == 71 && enemyShips < 7)
            {
                b9b1.Content = "-";
                enemyShips += 1;
            }
            else if (Convert.ToString(b9b1.Content) == "-" && value == 71 && enemyShips < 7)
            {
                SelectByEnemy();
            }

            if (Convert.ToString(b9b2.Content) == "." && value == 72 && enemyShips < 7)
            {
                b9b2.Content = "-";
                enemyShips += 1;
            }
            else if (Convert.ToString(b9b2.Content) == "-" && value == 72 && enemyShips < 7)
            {
                SelectByEnemy();
            }

            if (Convert.ToString(b9b3.Content) == "." && value == 73 && enemyShips < 7)
            {
                b9b3.Content = "-";
                enemyShips += 1;
            }
            else if (Convert.ToString(b9b3.Content) == "-" && value == 73 && enemyShips < 7)
            {
                SelectByEnemy();
            }

            if (Convert.ToString(b9b4.Content) == "." && value == 74 && enemyShips < 7)
            {
                b9b4.Content = "-";
                enemyShips += 1;
            }
            else if (Convert.ToString(b9b4.Content) == "-" && value == 74 && enemyShips < 7)
            {
                SelectByEnemy();
            }
        }

        /// /////////////////////////////////////////////////////////////////
        /// Player Attack
        /// /////////////////////////////////////////////////////////////////
        /// 
        void OnClickEnemy50(object sender, RoutedEventArgs e)
        {
            if (CheckCountToStart() == true && Convert.ToString(b5b0.Content) == ".")
            {
                b5b0.Content = "Miss!";
                b5b0.FontSize = 25;
                b5b0.Foreground = Brushes.Red;
                AttackByEnemy();
            }
            else if (CheckCountToStart() == true && Convert.ToString(b5b0.Content) == "-")
            {
                b5b0.Content = "X"; enemyShips -= 1;
                b5b0.FontSize = 50;
                b5b0.Foreground = Brushes.Red;
                AttackByEnemy();
                CheckCountToWin();
            }
        }

        void OnClickEnemy51(object sender, RoutedEventArgs e)
        {
            if (CheckCountToStart() == true && Convert.ToString(b5b1.Content) == ".")
            {
                b5b1.Content = "Miss!";
                b5b1.FontSize = 25;
                b5b1.Foreground = Brushes.Red;
                AttackByEnemy();
            }
            else if (CheckCountToStart() == true && Convert.ToString(b5b1.Content) == "-")
            {
                b5b1.Content = "X"; enemyShips -= 1;
                b5b1.FontSize = 50;
                b5b1.Foreground = Brushes.Red;
                AttackByEnemy();
                CheckCountToWin();
            }
        }

        void OnClickEnemy52(object sender, RoutedEventArgs e)
        {
            if (CheckCountToStart() == true && Convert.ToString(b5b2.Content) == ".")
            {
                b5b2.Content = "Miss!";
                b5b2.FontSize = 25;
                b5b2.Foreground = Brushes.Red;
                AttackByEnemy();
            }
            else if (CheckCountToStart() == true && Convert.ToString(b5b2.Content) == "-")
            {
                b5b2.Content = "X"; enemyShips -= 1;
                b5b2.FontSize = 50;
                b5b2.Foreground = Brushes.Red;
                AttackByEnemy();
                CheckCountToWin();
            }
        }

        void OnClickEnemy53(object sender, RoutedEventArgs e)
        {
            if (CheckCountToStart() == true && Convert.ToString(b5b3.Content) == ".")
            {
                b5b3.Content = "Miss!";
                b5b3.FontSize = 25;
                b5b3.Foreground = Brushes.Red;
                AttackByEnemy();
            }
            else if (CheckCountToStart() == true && Convert.ToString(b5b3.Content) == "-")
            {
                b5b3.Content = "X"; enemyShips -= 1;
                b5b3.FontSize = 50;
                b5b3.Foreground = Brushes.Red;
                AttackByEnemy();
                CheckCountToWin();
            }
        }

        void OnClickEnemy54(object sender, RoutedEventArgs e)
        {
            if (CheckCountToStart() == true && Convert.ToString(b5b4.Content) == ".")
            {
                b5b4.Content = "Miss!";
                b5b4.FontSize = 25;
                b5b4.Foreground = Brushes.Red;
                AttackByEnemy();
            }
            else if (CheckCountToStart() == true && Convert.ToString(b5b4.Content) == "-")
            {
                b5b4.Content = "X"; enemyShips -= 1;
                b5b4.FontSize = 50;
                b5b4.Foreground = Brushes.Red;
                AttackByEnemy();
                CheckCountToWin();
            }
        }

        /// ////////////////////////////////////////////////////////

        void OnClickEnemy60(object sender, RoutedEventArgs e)
        {
            if (CheckCountToStart() == true && Convert.ToString(b6b0.Content) == ".")
            {
                b6b0.Content = "Miss!";
                b6b0.FontSize = 25;
                b6b0.Foreground = Brushes.Red;
                AttackByEnemy();
            }
            else if (CheckCountToStart() == true && Convert.ToString(b6b0.Content) == "-")
            {
                b6b0.Content = "X"; enemyShips -= 1;
                b6b0.FontSize = 50;
                b6b0.Foreground = Brushes.Red;
                AttackByEnemy();
                CheckCountToWin();
            }
        }

        void OnClickEnemy61(object sender, RoutedEventArgs e)
        {
            if (CheckCountToStart() == true && Convert.ToString(b6b1.Content) == ".")
            {
                b6b1.Content = "Miss!";
                b6b1.FontSize = 25;
                b6b1.Foreground = Brushes.Red;
                AttackByEnemy();
            }
            else if (CheckCountToStart() == true && Convert.ToString(b6b1.Content) == "-")
            {
                b6b1.Content = "X"; enemyShips -= 1;
                b6b1.FontSize = 50;
                b6b1.Foreground = Brushes.Red;
                AttackByEnemy();
                CheckCountToWin();
            }
        }

        void OnClickEnemy62(object sender, RoutedEventArgs e)
        {
            if (CheckCountToStart() == true && Convert.ToString(b6b2.Content) == ".")
            {
                b6b2.Content = "Miss!";
                b6b2.FontSize = 25;
                b6b2.Foreground = Brushes.Red;
                AttackByEnemy();
            }
            else if (CheckCountToStart() == true && Convert.ToString(b6b2.Content) == "-")
            {
                b6b2.Content = "X"; enemyShips -= 1;
                b6b2.FontSize = 50;
                b6b2.Foreground = Brushes.Red;
                AttackByEnemy();
                CheckCountToWin();
            }
        }

        void OnClickEnemy63(object sender, RoutedEventArgs e)
        {
            if (CheckCountToStart() == true && Convert.ToString(b6b3.Content) == ".")
            {
                b6b3.Content = "Miss!";
                b6b3.FontSize = 25;
                b6b3.Foreground = Brushes.Red;
                AttackByEnemy();
            }
            else if (CheckCountToStart() == true && Convert.ToString(b6b3.Content) == "-")
            {
                b6b3.Content = "X"; enemyShips -= 1;
                b6b3.FontSize = 50;
                b6b3.Foreground = Brushes.Red;
                AttackByEnemy();
                CheckCountToWin();
            }
        }

        void OnClickEnemy64(object sender, RoutedEventArgs e)
        {
            if (CheckCountToStart() == true && Convert.ToString(b6b4.Content) == ".")
            {
                b6b4.Content = "Miss!";
                b6b4.FontSize = 25;
                b6b4.Foreground = Brushes.Red;
                AttackByEnemy();
            }
            else if (CheckCountToStart() == true && Convert.ToString(b6b4.Content) == "-")
            {
                b6b4.Content = "X"; enemyShips -= 1;
                b6b4.FontSize = 50;
                b6b4.Foreground = Brushes.Red;
                AttackByEnemy();
                CheckCountToWin();
            }
        }

        //////////////////////////////////////////////
        void OnClickEnemy70(object sender, RoutedEventArgs e)
        {
            if (CheckCountToStart() == true && Convert.ToString(b7b0.Content) == ".")
            {
                b7b0.Content = "Miss!";
                b7b0.FontSize = 25;
                b7b0.Foreground = Brushes.Red;
                AttackByEnemy();
            }
            else if (CheckCountToStart() == true && Convert.ToString(b7b0.Content) == "-")
            {
                b7b0.Content = "X"; enemyShips -= 1;
                b7b0.FontSize = 50;
                b7b0.Foreground = Brushes.Red;
                AttackByEnemy();
                CheckCountToWin();
            }
        }

        void OnClickEnemy71(object sender, RoutedEventArgs e)
        {
            if (CheckCountToStart() == true && Convert.ToString(b7b1.Content) == ".")
            {
                b7b1.Content = "Miss!";
                b7b1.FontSize = 25;
                b7b1.Foreground = Brushes.Red;
                AttackByEnemy();
            }
            else if (CheckCountToStart() == true && Convert.ToString(b7b1.Content) == "-")
            {
                b7b1.Content = "X"; enemyShips -= 1;
                b7b1.FontSize = 50;
                b7b1.Foreground = Brushes.Red;
                AttackByEnemy();
                CheckCountToWin();
            }
        }

        void OnClickEnemy72(object sender, RoutedEventArgs e)
        {
            if (CheckCountToStart() == true && Convert.ToString(b7b2.Content) == ".")
            {
                b7b2.Content = "Miss!";
                b7b2.FontSize = 25;
                b7b2.Foreground = Brushes.Red;
                AttackByEnemy();
            }
            else if (CheckCountToStart() == true && Convert.ToString(b7b2.Content) == "-")
            {
                b7b2.Content = "X"; enemyShips -= 1;
                b7b2.FontSize = 50;
                b7b2.Foreground = Brushes.Red;
                AttackByEnemy();
                CheckCountToWin();
            }
        }

        void OnClickEnemy73(object sender, RoutedEventArgs e)
        {
            if (CheckCountToStart() == true && Convert.ToString(b7b3.Content) == ".")
            {
                b7b3.Content = "Miss!";
                b7b3.FontSize = 25;
                b7b3.Foreground = Brushes.Red;
                AttackByEnemy();
            }
            else if (CheckCountToStart() == true && Convert.ToString(b7b3.Content) == "-")
            {
                b7b3.Content = "X"; enemyShips -= 1;
                b7b3.FontSize = 50;
                b7b3.Foreground = Brushes.Red;
                AttackByEnemy();
                CheckCountToWin();
            }
        }

        void OnClickEnemy74(object sender, RoutedEventArgs e)
        {
            if (CheckCountToStart() == true && Convert.ToString(b7b4.Content) == ".")
            {
                b7b4.Content = "Miss!";
                b7b4.FontSize = 25;
                b7b4.Foreground = Brushes.Red;
                AttackByEnemy();
            }
            else if (CheckCountToStart() == true && Convert.ToString(b7b4.Content) == "-")
            {
                b7b4.Content = "X"; enemyShips -= 1;
                b7b4.FontSize = 50;
                b7b4.Foreground = Brushes.Red;
                AttackByEnemy();
                CheckCountToWin();
            }
        }

        //////////////////////////////////////////////
        void OnClickEnemy80(object sender, RoutedEventArgs e)
        {
            if (CheckCountToStart() == true && Convert.ToString(b8b0.Content) == ".")
            {
                b8b0.Content = "Miss!";
                b8b0.FontSize = 25;
                b8b0.Foreground = Brushes.Red;
                AttackByEnemy();
            }
            else if (CheckCountToStart() == true && Convert.ToString(b8b0.Content) == "-")
            {
                b8b0.Content = "X"; enemyShips -= 1;
                b8b0.FontSize = 50;
                b8b0.Foreground = Brushes.Red;
                AttackByEnemy();
                CheckCountToWin();
            }
        }

        void OnClickEnemy81(object sender, RoutedEventArgs e)
        {
            if (CheckCountToStart() == true && Convert.ToString(b8b1.Content) == ".")
            {
                b8b1.Content = "Miss!";
                b8b1.FontSize = 25;
                b8b1.Foreground = Brushes.Red;
                AttackByEnemy();
            }
            else if (CheckCountToStart() == true && Convert.ToString(b8b1.Content) == "-")
            {
                b8b1.Content = "X"; enemyShips -= 1;
                b8b1.FontSize = 50;
                b8b1.Foreground = Brushes.Red;
                AttackByEnemy();
                CheckCountToWin();
            }
        }

        void OnClickEnemy82(object sender, RoutedEventArgs e)
        {
            if (CheckCountToStart() == true && Convert.ToString(b8b2.Content) == ".")
            {
                b8b2.Content = "Miss!";
                b8b2.FontSize = 25;
                b8b2.Foreground = Brushes.Red;
                AttackByEnemy();
            }
            else if (CheckCountToStart() == true && Convert.ToString(b8b2.Content) == "-")
            {
                b8b2.Content = "X"; enemyShips -= 1;
                b8b2.FontSize = 50;
                b8b2.Foreground = Brushes.Red;
                AttackByEnemy();
                CheckCountToWin();
            }
        }

        void OnClickEnemy83(object sender, RoutedEventArgs e)
        {
            if (CheckCountToStart() == true && Convert.ToString(b8b3.Content) == ".")
            {
                b8b3.Content = "Miss!";
                b8b3.FontSize = 25;
                b8b3.Foreground = Brushes.Red;
                AttackByEnemy();
            }
            else if (CheckCountToStart() == true && Convert.ToString(b8b3.Content) == "-")
            {
                b8b3.Content = "X"; enemyShips -= 1;
                b8b3.FontSize = 50;
                b8b3.Foreground = Brushes.Red;
                AttackByEnemy();
                CheckCountToWin();
            }
        }

        void OnClickEnemy84(object sender, RoutedEventArgs e)
        {
            if (CheckCountToStart() == true && Convert.ToString(b8b4.Content) == ".")
            {
                b8b4.Content = "Miss!";
                b8b4.FontSize = 25;
                b8b4.Foreground = Brushes.Red;
                AttackByEnemy();
            }
            else if (CheckCountToStart() == true && Convert.ToString(b8b4.Content) == "-")
            {
                b8b4.Content = "X"; enemyShips -= 1;
                b8b4.FontSize = 50;
                b8b4.Foreground = Brushes.Red;
                AttackByEnemy();
                CheckCountToWin();
            }
        }

        ////////////////////////////////////////////////////////
        void OnClickEnemy90(object sender, RoutedEventArgs e)
        {
            if (CheckCountToStart() == true && Convert.ToString(b9b0.Content) == ".")
            {
                b9b0.Content = "Miss!";
                b9b0.FontSize = 25;
                b9b0.Foreground = Brushes.Red;
                AttackByEnemy();
            }
            else if (CheckCountToStart() == true && Convert.ToString(b9b0.Content) == "-")
            {
                b9b0.Content = "X"; enemyShips -= 1;
                b9b0.FontSize = 50;
                b9b0.Foreground = Brushes.Red;
                AttackByEnemy();
                CheckCountToWin();
            }
        }

        void OnClickEnemy91(object sender, RoutedEventArgs e)
        {
            if (CheckCountToStart() == true && Convert.ToString(b9b1.Content) == ".")
            {
                b9b1.Content = "Miss!";
                b9b1.FontSize = 25;
                b9b1.Foreground = Brushes.Red;
                AttackByEnemy();
            }
            else if (CheckCountToStart() == true && Convert.ToString(b9b1.Content) == "-")
            {
                b9b1.Content = "X"; enemyShips -= 1;
                b9b1.FontSize = 50;
                b9b1.Foreground = Brushes.Red;
                AttackByEnemy();
                CheckCountToWin();
            }
        }

        void OnClickEnemy92(object sender, RoutedEventArgs e)
        {
            if (CheckCountToStart() == true && Convert.ToString(b9b2.Content) == ".")
            {
                b9b2.Content = "Miss!";
                b9b2.FontSize = 25;
                b9b2.Foreground = Brushes.Red;
                AttackByEnemy();
            }
            else if (CheckCountToStart() == true && Convert.ToString(b9b2.Content) == "-")
            {
                b9b2.Content = "X"; enemyShips -= 1;
                b9b2.FontSize = 50;
                b9b2.Foreground = Brushes.Red;
                AttackByEnemy();
                CheckCountToWin();
            }
        }

        void OnClickEnemy93(object sender, RoutedEventArgs e)
        {
            if (CheckCountToStart() == true && Convert.ToString(b9b3.Content) == ".")
            {
                b9b3.Content = "Miss!";
                b9b3.FontSize = 25;
                b9b3.Foreground = Brushes.Red;
                AttackByEnemy();
            }
            else if (CheckCountToStart() == true && Convert.ToString(b9b3.Content) == "-")
            {
                b9b3.Content = "X"; enemyShips -= 1;
                b9b3.FontSize = 50;
                b9b3.Foreground = Brushes.Red;
                AttackByEnemy();
                CheckCountToWin();
            }
        }

        void OnClickEnemy94(object sender, RoutedEventArgs e)
        {
            if (CheckCountToStart() == true && Convert.ToString(b9b4.Content) == ".")
            {
                b9b4.Content = "Miss!";
                b9b4.FontSize = 25;
                b9b4.Foreground = Brushes.Red;
                AttackByEnemy();
            }
            else if (CheckCountToStart() == true && Convert.ToString(b9b4.Content) == "-")
            {
                b9b4.Content = "X"; enemyShips -= 1;
                b9b4.FontSize = 50;
                b9b4.Foreground = Brushes.Red;
                AttackByEnemy();
                CheckCountToWin();
            }
        }



        /// //////////////////////////////////////////////////////////////////////////
        /// Player Select
        //////////////////////////////////////////////////////////////////////////////

        void OnClickPlayer00(object sender, RoutedEventArgs e)
        {
            if (CheckCountToStart() == false && Convert.ToString(a0a0.Content) == ".")
            {
                a0a0.Content = "-";
                a0a0.Background = Brushes.Blue;
                playerShips += 1;
            }
        }

        void OnClickPlayer01(object sender, RoutedEventArgs e)
            {
                if (CheckCountToStart() == false && Convert.ToString(a0a1.Content) == ".")
                {
                    a0a1.Content = "-";
                    a0a1.Background = Brushes.Blue;
                    playerShips += 1;
                }
            }

        void OnClickPlayer02(object sender, RoutedEventArgs e)
            {
                if (CheckCountToStart() == false && Convert.ToString(a0a2.Content) == ".")
                {
                    a0a2.Content = "-";
                    a0a2.Background = Brushes.Blue;
                    playerShips += 1;
                }
            }

        void OnClickPlayer03(object sender, RoutedEventArgs e)
            {
                if (CheckCountToStart() == false && Convert.ToString(a0a3.Content) == ".")
                {
                    a0a3.Content = "-";
                    a0a3.Background = Brushes.Blue;
                    playerShips += 1;
                }
            }

        void OnClickPlayer04(object sender, RoutedEventArgs e)
            {
                if (CheckCountToStart() == false && Convert.ToString(a0a4.Content) == ".")
                {
                    a0a4.Content = "-";
                    a0a4.Background = Brushes.Blue;
                    playerShips += 1;
                }
            }
            ///////////////////////////////////////////////////

        void OnClickPlayer10(object sender, RoutedEventArgs e)
            {
                if (CheckCountToStart() == false && Convert.ToString(a1a0.Content) == ".")
                {
                    a1a0.Content = "-";
                    a1a0.Background = Brushes.Blue;
                    playerShips += 1;
                }
            }

        void OnClickPlayer11(object sender, RoutedEventArgs e)
            {
                if (CheckCountToStart() == false && Convert.ToString(a1a1.Content) == ".")
                {
                    a1a1.Content = "-";
                    a1a1.Background = Brushes.Blue;
                    playerShips += 1;
                }
            }

        void OnClickPlayer12(object sender, RoutedEventArgs e)
            {
                if (CheckCountToStart() == false && Convert.ToString(a1a2.Content) == ".")
                {
                    a1a2.Content = "-";
                    a1a2.Background = Brushes.Blue;
                    playerShips += 1;
                }
            }

        void OnClickPlayer13(object sender, RoutedEventArgs e)
            {
                if (CheckCountToStart() == false && Convert.ToString(a1a3.Content) == ".")
                {
                    a1a3.Content = "-";
                    a1a3.Background = Brushes.Blue;
                    playerShips += 1;
                }
            }

        void OnClickPlayer14(object sender, RoutedEventArgs e)
            {
                if (CheckCountToStart() == false && Convert.ToString(a1a4.Content) == ".")
                {
                    a1a4.Content = "-";
                    a1a4.Background = Brushes.Blue;
                    playerShips += 1;
                }
            }
            //////////////////////////////////////////////////


        void OnClickPlayer20(object sender, RoutedEventArgs e)
            {
                if (CheckCountToStart() == false && Convert.ToString(a2a0.Content) == ".")
                {
                    a2a0.Content = "-";
                    a2a0.Background = Brushes.Blue;
                    playerShips += 1;
                }
            }

        void OnClickPlayer21(object sender, RoutedEventArgs e)
            {
                if (CheckCountToStart() == false && Convert.ToString(a2a1.Content) == ".")
                {
                    a2a1.Content = "-";
                    a2a1.Background = Brushes.Blue;
                    playerShips += 1;
                }
            }

        void OnClickPlayer22(object sender, RoutedEventArgs e)
            {
                if (CheckCountToStart() == false && Convert.ToString(a2a2.Content) == ".")
                {
                    a2a2.Content = "-";
                    a2a2.Background = Brushes.Blue;
                    playerShips += 1;
                }
            }

        void OnClickPlayer23(object sender, RoutedEventArgs e)
            {
                if (gameStart == false && Convert.ToString(a2a3.Content) == ".")
                {
                    a2a3.Content = "-";
                    a2a3.Background = Brushes.Blue;
                    playerShips += 1;
                }
            }

        void OnClickPlayer24(object sender, RoutedEventArgs e)
            {
                if (CheckCountToStart() == false && Convert.ToString(a2a4.Content) == ".")
                {
                    a2a4.Content = "-";
                    a2a4.Background = Brushes.Blue;
                    playerShips += 1;
                }
            }
            ////////////////////////////////////////////////////////////////

        void OnClickPlayer30(object sender, RoutedEventArgs e)
            {
                if (CheckCountToStart() == false && Convert.ToString(a3a0.Content) == ".")
                {
                    a3a0.Content = "-";
                    a3a0.Background = Brushes.Blue;
                    playerShips += 1;
                }
            }

        void OnClickPlayer31(object sender, RoutedEventArgs e)
            {
                if (CheckCountToStart() == false && Convert.ToString(a3a1.Content) == ".")
                {
                    a3a1.Content = "-";
                    a3a1.Background = Brushes.Blue;
                    playerShips += 1;
                }
            }

        void OnClickPlayer32(object sender, RoutedEventArgs e)
            {
                if (CheckCountToStart() == false && Convert.ToString(a3a2.Content) == ".")
                {
                    a3a2.Content = "-";
                    a3a2.Background = Brushes.Blue;
                    playerShips += 1;
                }
            }

        void OnClickPlayer33(object sender, RoutedEventArgs e)
            {
                if (CheckCountToStart() == false && Convert.ToString(a3a3.Content) == ".")
                {
                    a3a3.Content = "-";
                    a3a3.Background = Brushes.Blue;
                    playerShips += 1;
                }
            }

        void OnClickPlayer34(object sender, RoutedEventArgs e)
            {
                if (CheckCountToStart() == false && Convert.ToString(a3a4.Content) == ".")
                {
                    a3a4.Content = "-";
                    a3a4.Background = Brushes.Blue;
                    playerShips += 1;
                }
            }
            /////////////////////////////////////////////////////////

        void OnClickPlayer40(object sender, RoutedEventArgs e)
            {
                if (CheckCountToStart() == false && Convert.ToString(a4a0.Content) == ".")
                {
                    a4a0.Content = "-";
                    a4a0.Background = Brushes.Blue;
                    playerShips += 1;
                }
            }

        void OnClickPlayer41(object sender, RoutedEventArgs e)
            {
                if (CheckCountToStart() == false && Convert.ToString(a4a1.Content) == ".")
                {
                    a4a1.Content = "-";
                    a4a1.Background = Brushes.Blue;
                    playerShips += 1;
                }
            }

        void OnClickPlayer42(object sender, RoutedEventArgs e)
            {
                if (CheckCountToStart() == false && Convert.ToString(a4a2.Content) == ".")
                {
                    a4a2.Content = "-";
                    a4a2.Background = Brushes.Blue;
                    playerShips += 1;
                }
            }

        void OnClickPlayer43(object sender, RoutedEventArgs e)
            {
                if (CheckCountToStart() == false && Convert.ToString(a4a3.Content) == ".")
                {
                    a4a3.Content = "-";
                    a4a3.Background = Brushes.Blue;
                    playerShips += 1;
                }
            }

        void OnClickPlayer44(object sender, RoutedEventArgs e)
            {
                if (CheckCountToStart() == false && Convert.ToString(a4a4.Content) == ".")
                {
                    a4a4.Content = "-";
                    a4a4.Background = Brushes.Blue;
                    playerShips += 1;
                }
            }
        }
}

