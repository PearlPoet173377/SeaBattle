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
            if (playerShips >= 7 && gameStart == false)
            {
                SelectByEnemy();
                SelectByEnemy();
                SelectByEnemy();
                SelectByEnemy();
                SelectByEnemy();
                SelectByEnemy();
                SelectByEnemy();
                AttackByEnemy();
                gameStart = true;
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
                    Application.Current.Shutdown();
                }
                else if (enemyShips == 0)
                {
                    MessageBox.Show("You are winner!");
                    Application.Current.Shutdown();
                }
            }
        }

        /// //////////////////////////////////////////////////////////////////////////
        /// Choose Functions
        //////////////////////////////////////////////////////////////////////////////
       
        private Button ChooseToSelect()
        {
            Random ran = new Random();
            int value = ran.Next(50, 74);

            if (value == 50)
            {
                return b5b0;
            }
            else if (value == 51)
            {
                return b5b1;
            }
            else if (value == 52)
            {
                return b5b2;
            }
            else if (value == 53)
            {
                return b5b3;
            }
            else if (value == 54)
            {
                return b5b4;
            }
            //////////////////////    

            else if (value == 55)
            {
                return b6b0;
            }
            else if (value == 56)
            {
                return b6b1;
            }
            else if (value == 57)
            {
                return b6b2;
            }
            else if (value == 58)
            {
                return b6b3;
            }
            else if (value == 59)
            {
                return b6b4;
            }
            //////////////////////

            else if (value == 60)
            {
                return b7b0;
            }
            else if (value == 61)
            {
                return b7b1;
            }
            else if (value == 62)
            {
                return b7b2;
            }
            else if (value == 63)
            {
                return b7b3;
            }
            else if (value == 64)
            {
                return b7b4;
            }
            //////////////////////

            else if (value == 65)
            {
                return b8b0;
            }
            else if (value == 66)
            {
                return b8b1;
            }
            else if (value == 67)
            {
                return b8b2;
            }
            else if (value == 68)
            {
                return b8b3;
            }
            else if (value == 69)
            {
                return b8b4;
            }
            //////////////////////

            else if (value == 70)
            {
                return b9b0;
            }
            else if (value == 71)
            {
                return b9b1;
            }
            else if (value == 72)
            {
                return b9b2;
            }
            else if (value == 73)
            {
                return b9b3;
            }
            else if (value == 74)
            {
                return b9b4;
            }
            else
            {
                return ChooseToSelect();
            }
        }

        private Button ChooseToAttack()
        {
            Random ran = new Random();
            int value = ran.Next(0, 24);

            if (value == 0)
            {
                return a0a0;
            }
            else if (value == 1)
            {
                return a0a1;
            }
            else if (value == 2)
            {
                return a0a2;
            }
            else if (value == 3)
            {
                return a0a3;
            }
            else if (value == 4)
            {
                return a0a4;
            }
            ////////////////////// 
            
            if (value == 5)
            {
                return a1a0;
            }
            else if (value == 6)
            {
                return a1a1;
            }
            else if (value == 7)
            {
                return a1a2;
            }
            else if (value == 8)
            {
                return a1a3;
            }
            else if (value == 9)
            {
                return a1a4;
            }
            ////////////////////// 

            if (value == 10)
            {
                return a2a0;
            }
            else if (value == 11)
            {
                return a2a1;
            }
            else if (value == 12)
            {
                return a2a2;
            }
            else if (value == 13)
            {
                return a2a3;
            }
            else if (value == 14)
            {
                return a2a4;
            }
            ////////////////////// 

            if (value == 15)
            {
                return a3a0;
            }
            else if (value == 16)
            {
                return a3a1;
            }
            else if (value == 17)
            {
                return a3a2;
            }
            else if (value == 18)
            {
                return a3a3;
            }
            else if (value == 19)
            {
                return a3a4;
            }
            ////////////////////// 

            if (value == 20)
            {
                return a4a0;
            }
            else if (value == 21)
            {
                return a4a1;
            }
            else if (value == 22)
            {
                return a4a2;
            }
            else if (value == 23)
            {
                return a4a3;
            }
            else if (value == 24)
            {
                return a4a4;
            }
            else
            {
                return ChooseToAttack();
            }
        }

        /// //////////////////////////////////////////////////////////////////////////
        /// Enemy Attack
        //////////////////////////////////////////////////////////////////////////////
     
        private void AttackByEnemy()
        {
            Button obj = ChooseToAttack();
            if (Convert.ToString(obj.Content) == ".")
            {
                obj.Content = "Miss!";
                obj.FontSize = 25;
                obj.Foreground = Brushes.Red;
            }
            else if (Convert.ToString(obj.Content) == "-")
            {
                obj.Content = "X"; playerShips -= 1;
                obj.FontSize = 50;
                obj.Foreground = Brushes.Red;
                CheckCountToWin();
            }
            else
            {
                AttackByEnemy();
            }
        }

        ////////////////////////////////////////////////////////////////
        /// Enemy Select
        /////////////////////////////////////////////////////////////////////

        private void SelectByEnemy()
        {
            Button obj = ChooseToSelect();
            if (enemyShips < 7)
            {
                if (Convert.ToString(obj.Content) == ".")
                {
                    obj.Content = "-";
                    enemyShips += 1;
                }

                else if (Convert.ToString(obj.Content) == "-")
                {
                    SelectByEnemy();
                }
            }
        }

        /// /////////////////////////////////////////////////////////////////
        /// Player Attack
        /// /////////////////////////////////////////////////////////////////

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
                CheckCountToWin();
                AttackByEnemy();
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
                CheckCountToStart();
            }
        }
    }
}
