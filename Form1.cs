using System;
using System.Drawing;
using System.Windows.Forms;

namespace GameMapBuilder
{
    public partial class MainForm : Form
    {
        private ComboBox comboBuilderType;
        private ListBox listLog;
        private TextBox textResult;
        
        private MapBuilder _currentBuilder;
        private GameMapDirector _director;

        public MainForm()
        {
            InitializeComponent();
            InitializeCustomUI();
            
            SetBuilder(new EasyMapBuilder());
        }

        private void InitializeCustomUI()
        {
            this.Text = "Патерн Будівельник: Карта гри";
            this.Size = new Size(820, 600);
            this.StartPosition = FormStartPosition.CenterScreen;

            Label lblSelect = new Label() { Text = "1. Виберіть будівельника:", Location = new Point(20, 20), AutoSize = true, Font = new Font("Arial", 10, FontStyle.Bold) };
            
            comboBuilderType = new ComboBox() { Location = new Point(210, 20), Width = 150, DropDownStyle = ComboBoxStyle.DropDownList };
            comboBuilderType.Items.Add("Легка карта");
            comboBuilderType.Items.Add("Складна карта");
            comboBuilderType.SelectedIndex = 0;
            comboBuilderType.SelectedIndexChanged += ComboBuilderType_SelectedIndexChanged;

            GroupBox grpManual = new GroupBox() { Text = "2. Покрокове створення (Ручне)", Location = new Point(20, 60), Size = new Size(340, 260) };
            
            Button btnReset = new Button() { Text = "Reset() - Скинути", Location = new Point(20, 30), Width = 300 };
            btnReset.Click += (s, e) => _currentBuilder.Reset();
            
            Button btnTerrain = new Button() { Text = "BuildTerrain() - Рельєф", Location = new Point(20, 65), Width = 300 };
            btnTerrain.Click += (s, e) => _currentBuilder.BuildTerrain();
            
            Button btnEnemies = new Button() { Text = "BuildEnemies() - Вороги", Location = new Point(20, 100), Width = 300 };
            btnEnemies.Click += (s, e) => _currentBuilder.BuildEnemies();
            
            Button btnItems = new Button() { Text = "BuildItems() - Предмети", Location = new Point(20, 135), Width = 300 };
            btnItems.Click += (s, e) => _currentBuilder.BuildItems();
            
            Button btnObstacles = new Button() { Text = "BuildObstacles() - Перешкоди", Location = new Point(20, 170), Width = 300 };
            btnObstacles.Click += (s, e) => _currentBuilder.BuildObstacles();
            
            Button btnSpawn = new Button() { Text = "BuildSpawn() - Точка спавну", Location = new Point(20, 205), Width = 300 };
            btnSpawn.Click += (s, e) => _currentBuilder.BuildSpawn();

            grpManual.Controls.AddRange(new Control[] { btnReset, btnTerrain, btnEnemies, btnItems, btnObstacles, btnSpawn });

            GroupBox grpDirector = new GroupBox() { Text = "2. Створення через Директора", Location = new Point(20, 330), Size = new Size(340, 150) };
            
            Button btnCreateMap = new Button() { Text = "Director.CreateMap() - Повна карта", Location = new Point(20, 30), Width = 300 };
            btnCreateMap.Click += (s, e) => ShowResult(_director.CreateMap());
            
            Button btnCreateEasy = new Button() { Text = "Director.CreateEasyMap() - Легкий варіант", Location = new Point(20, 65), Width = 300 };
            btnCreateEasy.Click += (s, e) => ShowResult(_director.CreateEasyMap());
            
            Button btnCreateHard = new Button() { Text = "Director.CreateHardMap() - Складний варіант", Location = new Point(20, 100), Width = 300 };
            btnCreateHard.Click += (s, e) => ShowResult(_director.CreateHardMap());

            grpDirector.Controls.AddRange(new Control[] { btnCreateMap, btnCreateEasy, btnCreateHard });

            Button btnGetMap = new Button() { Text = "GetMap() - Отримати результат", Location = new Point(20, 490), Width = 340, Height = 40, Font = new Font("Arial", 10, FontStyle.Bold) };
            btnGetMap.Click += (s, e) => ShowResult(_currentBuilder.GetMap());

            Label lblLog = new Label() { Text = "Журнал виконання (Лог):", Location = new Point(380, 20), AutoSize = true, Font = new Font("Arial", 10, FontStyle.Bold) };
            listLog = new ListBox() { Location = new Point(380, 40), Size = new Size(400, 280), Font = new Font("Consolas", 10) };

            Label lblResult = new Label() { Text = "Фінальна карта:", Location = new Point(380, 330), AutoSize = true, Font = new Font("Arial", 10, FontStyle.Bold) };
            textResult = new TextBox() { Location = new Point(380, 350), Size = new Size(400, 180), Multiline = true, ReadOnly = true, Font = new Font("Consolas", 10), ScrollBars = ScrollBars.Vertical };

            this.Controls.AddRange(new Control[] { lblSelect, comboBuilderType, grpManual, grpDirector, btnGetMap, lblLog, listLog, lblResult, textResult });
        }

        private void ComboBuilderType_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (comboBuilderType.SelectedIndex == 0)
            {
                SetBuilder(new EasyMapBuilder());
            }
            else
            {
                SetBuilder(new HardMapBuilder());
            }
        }

        private void SetBuilder(MapBuilder builder)
        {
            if (_currentBuilder != null)
            {
                _currentBuilder.OnStepCompleted -= Builder_OnStepCompleted;
            }

            _currentBuilder = builder;
            _currentBuilder.OnStepCompleted += Builder_OnStepCompleted;

            if (_director == null)
            {
                _director = new GameMapDirector(_currentBuilder);
            }
            else
            {
                _director.SetBuilder(_currentBuilder);
            }

            LogMessage($"--- Змінено на {_currentBuilder.GetType().Name} ---");
        }

        private void Builder_OnStepCompleted(string message)
        {
            LogMessage(message);
        }

        private void LogMessage(string message)
        {
            if (listLog.InvokeRequired)
            {
                listLog.Invoke(new Action(() => LogMessage(message)));
                return;
            }
            listLog.Items.Add(message);
            listLog.TopIndex = listLog.Items.Count - 1;
        }

        private void ShowResult(GameMap map)
        {
            LogMessage("--- Карту створено! ---");
            textResult.Text = map.ToString();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "MainForm";
            this.Text = "Game Map Builder";
            this.ResumeLayout(false);
        }
    }
}
