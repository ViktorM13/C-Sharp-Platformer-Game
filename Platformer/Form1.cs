using System;
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

        int horizontalSpeed = 5;
        int verticalSpeed = 3;

        int enemyOneSpeed = 3;
        int enemyTwoSpeed = 3;

        // Переменные для анимации
        private Image spriteSheet;    // Полный спрайтовый лист
        private Bitmap playerSprite;  // Текущий спрайт игрока

        // Список объектов игры
        private List<GameObject> gameObjects;

        public Window()
        {
            InitializeComponent();
            music = new SoundPlayer("C:\\Users\\renda\\Pictures\\platformer\\sound.wav");
            music.Play();

            // Загружаем спрайтовый лист
            spriteSheet = Image.FromFile("C:\\Users\\renda\\Pictures\\platformer\\Animation.png");
            SetPlayerSprite(0, 0); // Устанавливаем начальный фрагмент (вперёд)

            // Создаем список объектов игры
            gameObjects = new List<GameObject>
            {
                new GameObject("coin", 25, 25, "C:\\Users\\renda\\Pictures\\platformer\\Money.png"),
                new GameObject("enemy", 25, 25, "C:\\Users\\renda\\Pictures\\platformer\\Enemy.png"),
                new GameObject("stone", 100, 20, "C:\\Users\\renda\\Pictures\\platformer\\Stone.jpg"),
                new GameObject("stone", 255, 430, "C:\\Users\\renda\\Pictures\\platformer\\Stone.jpg")
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

            if (goLeft == true)
                player.Left -= playerSpeed;

            if (goRight == true)
                player.Left += playerSpeed;

            if (jumping == true && force < 0)
                jumping = false;

            if (jumping == true)
            {
                jumpSpeed = -6;
                force -= 1;
            }
            else
            {
                jumpSpeed = 5;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    if ((string)x.Tag == "platform")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds))
                        {
                            force = 8;
                            player.Top = x.Top - player.Height;
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
                }
            }

            if (player.Top + player.Height > this.ClientSize.Height + 50)
            {
                gameTimer.Stop();
                music.Stop();
                isGameOver = true;
                scoreText.Text = "Score: " + score + Environment.NewLine + "You fell to your death!";
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

            if (e.KeyCode == Keys.Space && jumping == false)
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

            if (jumping == true)
            {
                jumping = false;
                SetPlayerSprite(0, 0); // Возвращаем вперёд
            }

            if (e.KeyCode == Keys.Enter && isGameOver == true)
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
                if (x is PictureBox && x.Visible == false)
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
            else if (Type == "stone")
            {
                PictureBox.Tag = "platform";
            }
        }
    }
}
