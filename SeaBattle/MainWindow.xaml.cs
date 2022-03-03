using System;
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

        private int playerShips = 0;
        private int enemyShips = 0;
        private bool gameStart = false;


        /// //////////////////////////////////////////////////////////////////////////
        /// Check Functions
        //////////////////////////////////////////////////////////////////////////////
        private bool CheckGameStart()
        {
            return gameStart;
        }

        private bool CheckCountToStart()
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

        private void CheckCountToWin()
        {
            if (gameStart == true)
            {
                if (playerShips == 0)
                {
                    MessageBox.Show("You are loser!");
                    System.Windows.Application.Current.Shutdown();
                }
                else if (enemyShips == 0)
                {
                    MessageBox.Show("You are winner!");
                    System.Windows.Application.Current.Shutdown();
                }
            }
        }



        /// //////////////////////////////////////////////////////////////////////////
        /// Enemy Attack
        //////////////////////////////////////////////////////////////////////////////
        private void AttackByEnemy()
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

        private void SelectByEnemy()
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

        private void OnClickEnemy(object sender, RoutedEventArgs e)
        {
            Button obj = sender as Button;
            if (CheckCountToStart() == true && Convert.ToString(obj.Content) == ".")
            {
                obj.Content = "Miss!";
                obj.FontSize = 25;
                obj.Foreground = Brushes.Red;
                AttackByEnemy();
            }
            else if (CheckCountToStart() == true && Convert.ToString(obj.Content) == "-")
            {
                obj.Content = "X"; enemyShips -= 1;
                obj.FontSize = 50;
                obj.Foreground = Brushes.Red;
                AttackByEnemy();
                CheckCountToWin();
            }
        }



        /// //////////////////////////////////////////////////////////////////////////
        /// Player Select
        //////////////////////////////////////////////////////////////////////////////


        private void OnClickPlayer(object sender, RoutedEventArgs e)
        {
            Button obj = sender as Button;
            if (CheckCountToStart() == false && Convert.ToString(obj.Content) == ".")
            {
                obj.Content = "-";
                obj.Background = Brushes.Blue;
                playerShips += 1;
            }
        }
    }
}

