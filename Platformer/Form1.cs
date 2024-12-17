﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace Platformer
{
    public partial class Window : Form
    {
        private SoundPlayer music;

        // Игровые переменные
        bool goLeft, goRight, jumping, isGameOver;

        int jumpSpeed;
        int force;
        int score = 0;
        int playerSpeed = 7;

        // Переменные для движения платформы
        private int platformSpeed = 2; // Скорость движения платформы
        private int platformStartX = 340; // Начальная координата X
        private int platformEndX = 640; // Конечная координата X
        private bool movingRight = true; // Направление движения платформы

        // Переменные для анимации
        private Image spriteSheet;    // Полный спрайтовый лист
        private Bitmap playerSprite;  // Текущий спрайт игрока

        // Список объектов игры
        private List<GameObject> gameObjects;

        public Window()
        {
            InitializeComponent();
            music = new SoundPlayer("C:\\Users\\MI\\Documents\\platformer\\sound.wav");
            music.Play();

            // Загружаем спрайтовый лист
            spriteSheet = Image.FromFile("C:\\Users\\MI\\Documents\\platformer\\Animation.png");
            SetPlayerSprite(0, 0); // Устанавливаем начальный фрагмент (вперёд)

            // Создаем список объектов игры
            gameObjects = new List<GameObject>
            {
                new GameObject("coin", 174, 479, "C:\\Users\\MI\\Documents\\platformer\\Money.png"),
                new GameObject("coin", 205, 479, "C:\\Users\\MI\\Documents\\platformer\\Money.png"),
                new GameObject("coin", 236, 479, "C:\\Users\\MI\\Documents\\platformer\\Money.png"),
                new GameObject("coin", 267, 479, "C:\\Users\\MI\\Documents\\platformer\\Money.png"),
                new GameObject("coin", 88, 218, "C:\\Users\\MI\\Documents\\platformer\\Money.png"),
                new GameObject("coin", 119, 218, "C:\\Users\\MI\\Documents\\platformer\\Money.png"),
                new GameObject("coin", 601, 479, "C:\\Users\\MI\\Documents\\platformer\\Money.png"),
                new GameObject("coin", 632, 479, "C:\\Users\\MI\\Documents\\platformer\\Money.png"),
                new GameObject("coin", 662, 479, "C:\\Users\\MI\\Documents\\platformer\\Money.png"),
                new GameObject("coin", 693, 479, "C:\\Users\\MI\\Documents\\platformer\\Money.png"),
                new GameObject("coin", 632, 127, "C:\\Users\\MI\\Documents\\platformer\\Money.png"),
                new GameObject("coin", 663, 127, "C:\\Users\\MI\\Documents\\platformer\\Money.png"),
                new GameObject("enemy", 267, 405, "C:\\Users\\MI\\Documents\\platformer\\Enemy.png"),
                new GameObject("enemy", 630, 325, "C:\\Users\\MI\\Documents\\platformer\\Enemy.png"),
                new GameObject("stone", 56, 370, "C:\\Users\\MI\\Documents\\platformer\\Stone.jpg"),
                new GameObject("stone", 215, 314, "C:\\Users\\MI\\Documents\\platformer\\Stone.jpg"),
                new GameObject("movingStone", 340, 265, "C:\\Users\\MI\\Documents\\platformer\\Stone.jpg"), // Двигающаяся платформа
                new GameObject("stone", 68, 249, "C:\\Users\\MI\\Documents\\platformer\\Stone.jpg"),
                new GameObject("stone", 68, 249, "C:\\Users\\MI\\Documents\\platformer\\Stone.jpg"),
                new GameObject("stone", 255, 430, "C:\\Users\\MI\\Documents\\platformer\\Stone.jpg"),
                new GameObject("stone", 562, 350, "C:\\Users\\MI\\Documents\\platformer\\Stone.jpg"),
                new GameObject("stone", 693, 429, "C:\\Users\\MI\\Documents\\platformer\\Stone.jpg"),
                new GameObject("stone", 609, 158, "C:\\Users\\MI\\Documents\\platformer\\Stone.jpg"),
                new GameObject("stone", 609, 158, "C:\\Users\\MI\\Documents\\platformer\\Stone.jpg"),
                new GameObject("stone", 760, 220, "C:\\Users\\MI\\Documents\\platformer\\Stone.jpg"),
                new GameObject("ground", 0, 510, "C:\\Users\\MI\\Documents\\platformer\\Ground.jpg"),
                new GameObject("ground", 585, 510, "C:\\Users\\MI\\Documents\\platformer\\Ground.jpg"),
                new GameObject("pointer", 830, 470, "C:\\Users\\MI\\Documents\\platformer\\Pointer.png")
            };

            // Добавляем объекты на форму, только если они видимы
            foreach (var obj in gameObjects)
            {
                if (obj.IsVisible)
                {
                    this.Controls.Add(obj.PictureBox);
                }
            }
        }

        // Метод для вырезки и установки нужного фрагмента спрайта
        private void SetPlayerSprite(int x, int y)
        {
            Rectangle section = new Rectangle(x, y, 35, 50);
            playerSprite = new Bitmap(35, 50);

            using (Graphics g = Graphics.FromImage(playerSprite))
            {
                g.DrawImage(spriteSheet, new Rectangle(0, 0, 35, 50), section, GraphicsUnit.Pixel);
            }

            player.Image = playerSprite;
        }

        // Основная логика игры
        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            scoreText.Text = "Score: " + score;
            player.Top += jumpSpeed;

            // Движение платформы
            MoveMovingStone();

            if (goLeft)
                player.Left -= playerSpeed;

            if (goRight)
                player.Left += playerSpeed;

            if (jumping && force < 0)
                jumping = false;

            if (jumping)
            {
                jumpSpeed = -6;
                force -= 1;
            }
            else
            {
                jumpSpeed = 5;
            }

            CheckCollisions();
            CheckGameOver();
        }

        // Метод для проверки столкновений
        private void CheckCollisions()
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    if ((string)x.Tag == "platform" || (string)x.Tag == "movingStone")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds))
                        {
                            force = 8; // Устанавливаем силу прыжка
                            player.Top = x.Top - player.Height; // Устанавливаем игрока на верх платформы
                        }
                    }

                    if ((string)x.Tag == "coin")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds) && x.Visible)
                        {
                            x.Visible = false;
                            score++;
                        }
                    }

                    if ((string)x.Tag == "enemy")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds))
                        {
                            gameTimer.Stop();
                            music.Stop();
                            isGameOver = true;
                            scoreText.Text = "Score: " + score + Environment.NewLine + "You were killed in your journey!";
                        }
                    }

                    // Проверка столкновения с указателем
                    if ((string)x.Tag == "pointer")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds))
                        {
                            gameTimer.Stop();
                            music.Stop();
                            isGameOver = true;
                            scoreText.Text = "Score: " + score + Environment.NewLine + "You won!";
                        }
                    }
                }
            }
        }

        // Метод для проверки окончания игры
        private void CheckGameOver()
        {
            if (player.Top + player.Height > this.ClientSize.Height + 50)
            {
                gameTimer.Stop();
                music.Stop();
                isGameOver = true;
                scoreText.Text = "Score: " + score + Environment.NewLine + "You fell to your death!";
            }
        }

        // Метод для движения платформы movingStone
        private void MoveMovingStone()
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "movingStone")
                {
                    if (x.Left >= platformEndX) // Если платформа достигла конца
                    {
                        movingRight = false; // Меняем направление на лево
                    }
                    else if (x.Left <= platformStartX) // Если платформа достигла начала
                    {
                        movingRight = true; // Меняем направление на право
                    }

                    // Двигаем платформу
                    if (movingRight)
                    {
                        x.Left += platformSpeed; // Двигаем вправо
                    }
                    else
                    {
                        x.Left -= platformSpeed; // Двигаем влево
                    }
                }
            }
        }

        // Обработка нажатий клавиш
        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
                SetPlayerSprite(0, 50); // Назад
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
                SetPlayerSprite(0, 0); // Вперёд
            }

            if (e.KeyCode == Keys.Space && !jumping)
            {
                jumping = true;

                if (goLeft)
                    SetPlayerSprite(35, 0); // Прыжок назад
                else
                    SetPlayerSprite(35, 50); // Прыжок вперёд
            }
        }

        // Обработка отпускания клавиш
        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
                SetPlayerSprite(0, 0); // Возвращаем вперёд
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
                SetPlayerSprite(0, 0); // Возвращаем вперёд
            }

            if (jumping)
            {
                jumping = false;
                SetPlayerSprite(0, 0); // Возвращаем вперёд
            }

            if (e.KeyCode == Keys.Enter && isGameOver)
                RestartGame();
        }

        // Перезапуск игры
        private void RestartGame()
        {
            jumping = false;
            goLeft = false;
            goRight = false;
            isGameOver = false;
            score = 0;
            scoreText.Text = "Score: " + score;

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && !x.Visible)
                    x.Visible = true;
            }

            player.Left = 55;
            player.Top = 460;

            gameTimer.Start();
            music.Play();
            SetPlayerSprite(0, 0); // Вперёд
        }
    }

    public class GameObject
    {
        public PictureBox PictureBox { get; set; }
        public string Type { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public bool IsVisible { get; set; }

        public GameObject(string type, int x, int y, string imagePath)
        {
            Type = type;
            X = x;
            Y = y;
            IsVisible = true;  // Убедитесь, что объект видим по умолчанию

            // Создаем PictureBox для отображения объекта
            PictureBox = new PictureBox
            {
                Left = x,
                Top = y,
                BackColor = Color.Transparent // Убираем фон
            };

            // Загружаем изображение для объекта
            Image img = Image.FromFile(imagePath);
            PictureBox.Image = img;

            // Подгоняем размер PictureBox под размер изображения
            PictureBox.Size = new Size(img.Width, img.Height);

            // Привязываем тег для различения типов объектов
            if (Type == "coin")
            {
                PictureBox.Tag = "coin";
            }
            else if (Type == "enemy")
            {
                PictureBox.Tag = "enemy";
            }
            else if (Type == "stone" || Type == "ground")
            {
                PictureBox.Tag = "platform";
            }
            else if (Type == "pointer")
            {
                PictureBox.Tag = "pointer";
            }
            else if (Type == "movingStone")
            {
                PictureBox.Tag = "movingStone";
            }
        }
    }
}
