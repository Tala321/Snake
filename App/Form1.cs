using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace App
{
    public partial class Form1 : Form
    {

        Button meal = new Button();
        Button body = new Button();
        List<Button> bodies = new List<Button>();
        List<Keys> Pressedkeys = new List<Keys>();


        int startBodyPositionTop = 0;
        int startBodyPositionTop2 = 0;
        int startBodyPositionLeft = 0;
        int startBodyPositionLeft2 = 0;
        int count = 0;
        int count1 = 0;
        int count2 = 0;


        public Form1()
        {
            InitializeComponent();
        }


        // this method is for manupulating the snake 
        private void btnSnake_KeyDown(object sender, KeyEventArgs e)
        {
            textBox1.Text = btnSnake.Location.X.ToString();
            textBox2.Text = btnSnake.Location.Y.ToString();


            if (e.KeyCode == Keys.W)
            {

                changeBodyPosition(1);
                MoveAddedBodyWithSnake(0, 0, 1);
                btnSnake.Top -= 20;
                SnakeEatMeal(btnSnake.Left, 20, 1);
                Pressedkeys.Add(Keys.W);
            }
            if (e.KeyCode == Keys.S)
            {
                count = 0;
                MoveAddedBodyWithSnake(0, 0, 2);
                btnSnake.Top += 20;
                SnakeEatMeal(btnSnake.Left, -20, 2);
                Pressedkeys.Add(Keys.S);
            }
            if (e.KeyCode == Keys.D)
            {
                count = 0;
                MoveAddedBodyWithSnake(0, 0, 3);
                btnSnake.Left += 20;
                SnakeEatMeal(-20, btnSnake.Top, 3);
                Pressedkeys.Add(Keys.D);

            }
            if (e.KeyCode == Keys.A)
            {
                changeBodyPosition(2);
                MoveAddedBodyWithSnake(0, 0, 4);
                btnSnake.Left -= 20;
                SnakeEatMeal(20, btnSnake.Top, 4);
                Pressedkeys.Add(Keys.A);
            }
        }

        // to change bodies position according to pressed button (W,S,A,D)

        private void changeBodyPosition(int _left)
        {

        }

        //Methods that runs when openes the form
        private void Form1_Load(object sender, EventArgs e)
        {
            RandomMealLocation();

            textBox1.Text = btnSnake.Location.X.ToString();
            textBox2.Text = btnSnake.Location.Y.ToString();
        }

        // That's what happens when the snake eats the meal 
        private void SnakeEatMeal(int _left, int _top, int keyCode)
        {

            int mealLocationX = btnMeal.Left;
            int mealLocationY = btnMeal.Top;

            if (btnSnake.Left == btnMeal.Left && btnSnake.Top == btnMeal.Top)
            {
                RandomMealLocation();
                AddBodyToSnake(_left, _top, keyCode);
            }
        }

        //Add  a body to a snake after it eats the meal

        private void AddBodyToSnake(int _left, int _top, int _keyCode)//, int _startBodyPositionTop)
        {
            body = new Button();
            this.Controls.Add(body);
            bodies.Add(body);
            body.Height = 20;
            body.Width = 20;
            body.BackColor = Color.Green;

            if (_left == btnSnake.Left)
            {
                if (_keyCode == 1)
                {
                    int snakeBodyLocationX = btnSnake.Left;
                    int snakeBodyLocationY = btnSnake.Top + _top + startBodyPositionTop;
                    body.Top = snakeBodyLocationY;
                    body.Left = snakeBodyLocationX;
                    startBodyPositionTop += 20;
                    startBodyPositionTop2 -= 20;
                    startBodyPositionLeft2 -= 20;
                    startBodyPositionLeft += 20;

                }
                else if (_keyCode == 2)
                {
                    int snakeBodyLocationX = btnSnake.Left;
                    int snakeBodyLocationY = btnSnake.Top + _top + startBodyPositionTop2;
                    body.Top = snakeBodyLocationY;
                    body.Left = snakeBodyLocationX;
                    startBodyPositionTop += 20;
                    startBodyPositionTop2 -= 20;
                    startBodyPositionLeft2 -= 20;
                    startBodyPositionLeft += 20;
                }
            }
            else
            {
                if (_keyCode == 3)
                {
                    int snakeBodyLocationX = btnSnake.Left + _left + startBodyPositionLeft2;
                    int snakeBodyLocationY = btnSnake.Top;
                    body.Top = snakeBodyLocationY;
                    body.Left = snakeBodyLocationX;
                    startBodyPositionTop += 20;
                    startBodyPositionTop2 -= 20;
                    startBodyPositionLeft2 -= 20;
                    startBodyPositionLeft += 20;
                }
                else if (_keyCode == 4)
                {
                    int snakeBodyLocationX = btnSnake.Left + _left + startBodyPositionLeft;
                    int snakeBodyLocationY = btnSnake.Top;
                    body.Top = snakeBodyLocationY;
                    body.Left = snakeBodyLocationX;
                    startBodyPositionTop += 20;
                    startBodyPositionTop2 -= 20;
                    startBodyPositionLeft2 -= 20;
                    startBodyPositionLeft += 20;
                }
            }
        }


        //Add Body
       int  count5=0;
        private void MoveAddedBodyWithSnake(int _left, int _top, int _keyCode)
        {
            int count = 0;
            foreach (var item in bodies)
            {
                if (count == 0)
                {
                    item.Left = btnSnake.Left + _left;
                    item.Top = btnSnake.Top + _top;
                }
            }
            for (var i = 1; i < bodies.Count; i++)
            {
                //for (var t = Pressedkeys.Count; t < Pressedkeys.Count; t++)
                //{
                if (_keyCode == 1)
                {

                    bodies[i].Left = bodies[i - 1].Left;
                    bodies[i].Top = bodies[i - 1].Top + 20;

                }
                else if (_keyCode == 2)
                {
                    if (Pressedkeys[Pressedkeys.Count - 1] != Keys.S)
                    {
                       
                            bodies[i].Left = bodies[i - 1].Left + 20;
                            bodies[i].Top = bodies[i - 1].Top;
                                                           
                    }
                    else
                    {
                        bodies[i].Left = bodies[i - 1].Left;
                        bodies[i].Top = bodies[i - 1].Top - 20;
                    }

                }

                else if (_keyCode == 3)
                {
                    bodies[i].Left = bodies[i - 1].Left - 20;
                    bodies[i].Top = bodies[i - 1].Top;

                }
                else if (_keyCode == 4)
                {
                    bodies[i].Left = bodies[i - 1].Left + 20;
                    bodies[i].Top = bodies[i - 1].Top;
                }
                //}
            }
        }

        //Change Position

        private void ChangePostion()
        {
            foreach (var item in bodies)
            {
                item.Top = -(20);
                item.Left = -(20);
            }
        }

        // this method is for Random meal Location 
        private void RandomMealLocation()
        {
            btnMeal.Top = new Random().Next(1, 10) * 20;
            btnMeal.Left = new Random().Next(1, 20) * 20;
        }
    }
}

