using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private List<Button> allButtons;
        private Queue<ButtonSpawn> spawnQueue;
        private int currentTime = 0;
        private int score = 0;
        private Label scoreLabel;
        private Random random;

        public Form1()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {

            random = new Random();
            allButtons = new List<Button> { button1, button4, button5, button8 };

            foreach (var btn in allButtons)
            {
                btn.Visible = false;
                btn.Click += Button_Click;
                btn.Size = new Size(80, 80); 
            }

            spawnQueue = GenerateRandomSpawns(60); 

            scoreLabel = new Label
            {
                Location = new Point(10, 10),
                Size = new Size(200, 30),
            };
            this.Controls.Add(scoreLabel);
            
            timer1.Interval = 16;
            timer1.Tick += Timer1_Tick;
            timer1.Start();
        }

        private Queue<ButtonSpawn> GenerateRandomSpawns(int count)
        {
            var spawns = new List<ButtonSpawn>();
            int currentSpawnTime = 500;

            for (int i = 0; i < count; i++)
            {
                
                Button randomButton = allButtons[random.Next(allButtons.Count)];

                Point randomPosition = GetRandomPosition();

                spawns.Add(new ButtonSpawn
                {
                    Time = currentSpawnTime,
                    Button = randomButton,
                    Position = randomPosition
                });

                currentSpawnTime += random.Next(350, 750);
            }

            return new Queue<ButtonSpawn>(spawns);
        }

        private Point GetRandomPosition()
        {
            int margin = 100;
            int x = random.Next(margin, this.ClientSize.Width - margin);
            int y = random.Next(margin + 50, this.ClientSize.Height - margin);

            return new Point(x, y);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            currentTime += timer1.Interval;

            while (spawnQueue.Count > 0 && spawnQueue.Peek().Time <= currentTime)
            {
                var spawn = spawnQueue.Dequeue();
                spawn.Button.Visible = true;
                spawn.Button.BackColor = Color.LightBlue;
                spawn.Button.Location = spawn.Position; 
                spawn.Button.Tag = currentTime;
            }

            foreach (var btn in allButtons.Where(b => b.Visible))
            {
                if (btn.Tag != null)
                {
                    int spawnTime = (int)btn.Tag;
                    if (currentTime - spawnTime > 3000)
                    {
                        btn.Visible = false;
                        btn.BackColor = SystemColors.Control;
                        btn.Tag = null;
                    }
                }
            }

            if (spawnQueue.Count == 0 && !allButtons.Any(b => b.Visible))
            {
                timer1.Stop();
                MessageBox.Show($"¡Juego terminado!\nPuntuación final: {score}", "Fin del juego");
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Visible && btn.Tag != null)
            {
                int spawnTime = (int)btn.Tag;
                int timeDiff = currentTime - spawnTime;
                int points = CalculatePoints(timeDiff);

                score += points;
                scoreLabel.Text = $"Score: {score}";

                btn.BackColor = points >= 100 ? Color.LightGreen : Color.Yellow;
                btn.Tag = null;

                var hideTimer = new Timer { Interval = 100 };
                hideTimer.Tick += (s, ev) => {
                    btn.Visible = false;
                    btn.BackColor = SystemColors.Control;
                    hideTimer.Stop();
                };
                hideTimer.Start();
            }
        }

        private int CalculatePoints(int timeDiff)
        {

            if (timeDiff < 200) return 150; 
            if (timeDiff < 500) return 100; 
            if (timeDiff < 1000) return 50; 
            return 25; 
        }

        private class ButtonSpawn
        {
            public int Time { get; set; }
            public Button Button { get; set; }
            public Point Position { get; set; }
        }

        private void button8_Click(object sender, EventArgs e)
        {
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}