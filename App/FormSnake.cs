using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using  System.Timers;
using System.Windows.Forms;

namespace App
{
    public partial class FormSnake : Form
    {

        Button meal = new Button();
        Button body = new Button();
        List<Button> bodies = new List<Button>();

        //Keys status
        static bool KeyW = true;
        static bool KeyS = true;
        static bool KeyD = true;
        static bool KeyA = true;


        public FormSnake()
        {
            InitializeComponent();
            btnMeal.Enabled = false;
            bodies.Add(btnSnake);           
        }

        // this method is for manupulating the snake 
        private void FormSnake_KeyDown(object sender, KeyEventArgs e)
        {
            MoveEngine(e);
        }
   

        //Moves Head and bodies of the snake
        private void MoveEngine(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W && KeyW == true)
            {
                MoveSnake();
                btnSnake.Top -= 20;
                SnakeEatMeal();
                KeyS = false;
                KeyD = true;
                KeyA = true;
            }

            if (e.KeyCode == Keys.S && KeyS == true)
            {
                MoveSnake();
                btnSnake.Top += 20;
                SnakeEatMeal();
                KeyW = false;
                KeyD = true;
                KeyA = true;
            }

            if (e.KeyCode == Keys.D && KeyD == true)
            {
                MoveSnake();
                btnSnake.Left += 20;
                SnakeEatMeal();
                KeyA = false;
                KeyW = true;
                KeyS = true;
            }

            if (e.KeyCode == Keys.A && KeyA == true)
            {
                MoveSnake();
                btnSnake.Left -= 20;
                SnakeEatMeal();
                KeyD = false;
                KeyW = true;
                KeyS = true;
            }
        }


        //Snake Bodies move engine
        private void MoveSnake()
        {
            for (int i = bodies.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    //nothing happens...
                }
                else
                {
                    bodies[i].Left = bodies[i - 1].Left;
                    bodies[i].Top = bodies[i - 1].Top;
                }
            }
        }

        //Random meal location when game starts
        private void FormSnake_Load(object sender, EventArgs e)
        {
            RandomMealLocation();
        }


        // That's what happens when the snake eats the meal 
        private void SnakeEatMeal()
        {
            if (btnSnake.Left == btnMeal.Left && btnSnake.Top == btnMeal.Top)
            {
                RandomMealLocation();
                AddBodyToSnake();
            }
        }

        //Creating new body part after eating the meal
        private void AddBodyToSnake()
        {
            body = new Button();
            //
            body.Top = bodies[bodies.Count - 1].Top;
            body.Left = bodies[bodies.Count - 1].Left;
            //
            body.Height = 20;
            body.Width = 20;
            body.Enabled = false;
            body.BackColor = Color.Green;
            bodies.Add(body);
            this.Controls.Add(body);
           
        }

        //Check if the meal  creates on the snake body
        private bool CheckMealLocation(int _top, int _left)
        {
            for (int i = 0; i < bodies.Count; i++)
            {
                if (bodies[i].Top == _top && bodies[i].Left == _left)
                {
                    return false;
                }
            }
            return true;
        }

        //Random meal Location 
        private void RandomMealLocation()
        {
            int Top = new Random().Next(1, 17) * 20;
            int Left = new Random().Next(1, 17) * 20;
            if (CheckMealLocation(Top, Left))
            {
                btnMeal.Left = Left;
                btnMeal.Top = Top;
            }
            else
            {
                RandomMealLocation();
            }
        }
    }
}

