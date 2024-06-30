using System;
using System.IO;
using System.Windows.Forms;

namespace Clicker
{
    public partial class Window : Form
    {
        private float _money = 0f;       // текущее кол-во монет
        private float _progress = 1f;    // множитель монет
        private ulong _perClick = 1;     // монет за клик
        private ulong _clickCost = 100;  // цена за улучшение клика
        private ulong _perSecond = 0;    // монет в секунду
        private ulong _secCost = 1000;    // цена за улучшение кол-ва монет в секунду

        // функция сохранения
        private void Save()
        {
            if (MessageBox.Show("Сохранить данные?", "Сохранение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // создание папки
                Directory.CreateDirectory("C:\\ProgramData\\BlackDragon3129\\Clicker");

                // текст для записи
                string text = "Hi! It's BlackDragon3129. What are you doing here? Are you a hacker? " +
                        "Here's some numbers. Please, don't touch anything! See you later!\n" +
                        _money.ToString() + '\n' +
                        _progress.ToString() + '\n' +
                        _perClick.ToString() + '\n' +
                        _clickCost.ToString() + '\n' +
                        _perSecond.ToString() + '\n' +
                        _secCost.ToString();

                // запись в файл
                File.WriteAllText("C:\\ProgramData\\BlackDragon3129\\Clicker\\data.ЭтоРасширениеБесполезноЗачемОно",
                    text);
            }
        }

        // конвертатор в буквы
        private string ToLetterConverter(ulong value)
        {
            string letterValue;
            if (value / 1_000_000_000_000f > 1f)
                letterValue = Math.Round((decimal)value / 1_000_000_000_000, 2).ToString() + "T";
            else if (value / 1_000_000_000f > 1f)
                letterValue = Math.Round((decimal)value / 1_000_000_000, 2).ToString() + "B";
            else if (value / 1_000_000f > 1f)
                letterValue = Math.Round((decimal)value / 1_000_000, 2).ToString() + "M";
            else if (value / 1_000f > 1f)
                letterValue = Math.Round((decimal)value / 1_000, 2).ToString() + "K";
            else
                letterValue = value.ToString();

            return letterValue;
        }
        private string ToLetterConverter(float value)
        {
            string letterValue;
            if (value / 1_000_000_000_000f > 1f)
                letterValue = Math.Round((decimal)value / 1_000_000_000_000, 2).ToString() + "T";
            else if (value / 1_000_000_000f > 1f)
                letterValue = Math.Round((decimal)value / 1_000_000_000, 2).ToString() + "B";
            else if (value / 1_000_000f > 1f)
                letterValue = Math.Round((decimal)value / 1_000_000, 2).ToString() + "M";
            else if (value / 1_000f > 1f)
                letterValue = Math.Round((decimal)value / 1_000, 2).ToString() + "K";
            else
                letterValue = value.ToString();

            return letterValue;
        }

        public Window()
        {
            InitializeComponent();
        }

        // загрузка
        private void Window_Load(object sender, EventArgs e)
        {
            // загрузка из файла
            try
            {
                string[] values =
                    File.ReadAllLines("C:\\ProgramData\\BlackDragon3129\\Clicker\\data.ЭтоРасширениеБесполезноЗачемОно");
                // попытка взлома
                if (values[0] != "Hi! It's BlackDragon3129. What are you doing here? Are you a hacker? " +
                    "Here's some numbers. Please, don't touch anything! See you later!")
                {
                    _money = 0f;
                    _progress = 0.1f;
                    _perClick = 0;
                    _clickCost = 999_999_999_999;
                    _perSecond = 0;
                    _secCost = 999_999_999_999;

                    File.WriteAllText("C:\\ProgramData\\BlackDragon3129\\Clicker\\data.ЭтоРасщирениеБесполезноЗачемОно",
                        "Hi, ******* hacker!\n0\n0.1\n0\n999999999999\n0\n999999999999");
                }
                // всё хорошо
                else
                {
                    _money = Convert.ToSingle(values[1]);
                    _progress = Convert.ToSingle(values[2]);
                    _perClick = Convert.ToUInt64(values[3]);
                    _clickCost = Convert.ToUInt64(values[4]);
                    _perSecond = Convert.ToUInt64(values[5]);
                    _secCost = Convert.ToUInt64(values[6]);
                }
            }
            // файл не найден
            catch
            {
                _money = 0f;
                _progress = 1f;
                _perClick = 1;
                _clickCost = 100;
                _perSecond = 0;
                _secCost = 1000;
            }
            // синхронизация
            finally
            {
                // монеты

                MoneyLabel.Text = ToLetterConverter(_money) + " ☺";

                // клик
                PerClickLabel.Text = "За клик: " + ToLetterConverter(_perClick) + " ☺";
                ClickCostLabel.Text = "Цена улучшения клика: " + ToLetterConverter(_clickCost) + " ☺";

                // в секунду
                PerSecondLabel.Text = "В секунду: " + ToLetterConverter(_perSecond) + " ☺";
                SecCostLabel.Text = "Цена улучшения секунды: " + ToLetterConverter(_secCost) + " ☺";

                // множитель
                XLabel.Text = "Множитель: x" + _progress.ToString();

                // блок/разблокировка кнопок клика и прогресса
                if (_money >= 100_000_000_000f)
                    ProgressDropButton.Enabled = true;
                if (_money + _perClick > ulong.MaxValue)
                    ClickButton.Enabled = false;
            }
        }

        // сохранение
        private void Window_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (File.ReadAllLines("C:\\ProgramData\\BlackDragon3129\\Clicker\\data.ЭтоРасширениеБесполезноЗачемОно")[0]
                    == "Hi! It's BlackDragon3129. What are you doing here? Are you a hacker? " +
                        "Here's some numbers. Please, don't touch anything! See you later!")
                {
                    Save();
                }
            }
            catch
            {
                Save(); 
            }
        }

        // улучшение клика
        private void ClickUpgrade_Click(object sender, EventArgs e)
        {
            // расчёты
            if (_money >= _clickCost)
            {
                // уменьшение монет
                _money -= _clickCost;

                // подорожание клика
                _perClick ++;

                // перерасчёт стоимости
                Random random = new Random();
                _clickCost = _perClick * (ulong)random.Next(90, 111) * _perClick;
            }

            // разблокировка кнопки клика
            if (_money + _perClick > ulong.MaxValue)
                ClickButton.Enabled = true;

            // синхронизация
            MoneyLabel.Text = ToLetterConverter(_money) + " ☺";
            ClickCostLabel.Text = "Цена улучшения клика: " + ToLetterConverter(_clickCost) + " ☺";
            PerClickLabel.Text = "За клик: " + ToLetterConverter(_perClick) + " ☺";
        }

        // выход
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // новая игра
        private void NewGameButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены все заначения (включая множитель) вернутся к базовым!", "Точно?",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // переопределение занчений
                _money = 0f;
                _progress = 1f;
                _perClick = 1;
                _clickCost = 100;
                _perSecond = 0;
                _secCost = 1000;

                // удаление сохранения
                if (File.Exists("C:\\ProgramData\\BlackDragon3129\\Clicker\\data.ЭтоРасширениеБесполезноЗачемОно"))
                    File.Delete("C:\\ProgramData\\BlackDragon3129\\Clicker\\data.ЭтоРасширениеБесполезноЗачемОно");

                // синхронизация
                MoneyLabel.Text = "0 ☺";
                PerClickLabel.Text = "За клик: 1 ☺";
                ClickCostLabel.Text = "Цена улучшения клика: 100 ☺";
                PerSecondLabel.Text = "В секунду: 0 ☺";
                SecCostLabel.Text = "Цена улучшения секунды: 100 ☺";
                XLabel.Text = "Множитель: x1";
            }
        }

        // сброс прогресса
        private void ProgressDropButton_Click(object sender, EventArgs e)
        {
            // обновление множителя
            _progress += 0.2f;

            // сброс значений
            _money = 0f;
            _perClick = 1;
            _clickCost = 100;
            _perSecond = 0;
            _secCost = 100;

            // синхронизация
            MoneyLabel.Text = "0 ☺";
            PerClickLabel.Text = "За клик: 1 ☺";
            ClickCostLabel.Text = "Цена улучшения клика: 100 ☺";
            PerSecondLabel.Text = "В секунду: 0 ☺";
            SecCostLabel.Text = "Цена улучшения секунды: 100 ☺";
            XLabel.Text = "Множитель: x" + _progress.ToString();
        }

        // клик
        private void ClickButton_MouseClick(object sender, MouseEventArgs e)
        {
            // прибавка монет
            _money += _perClick * _progress;

            // разблокировка сброса прогресса
            ulong roundMoney = ((ulong)Math.Round((decimal)_money)); ;
            if (roundMoney >= 100_000_000_000)
                ProgressDropButton.Enabled = true;

            // блокировка, если при следуюущем нажатии переполнение
            if (_money + _perClick > ulong.MaxValue)
                ClickButton.Enabled = false;

            // синхронизация
            MoneyLabel.Text = ToLetterConverter(_money) + " ☺";
        }

        private void SecondTimer_Tick(object sender, EventArgs e)
        {
            // прибавка монет
            _money += _perSecond * _progress;

            // синхронизация
            MoneyLabel.Text = ToLetterConverter(_money) + " ☺";
        }

        private void SecUpgrade_Click(object sender, EventArgs e)
        {
            // расчёты
            if (_money >= _secCost)
            {
                // уменьшение монет
                _money -= _secCost;

                // подорожание секунды
                _perSecond++;

                // перерасчёт стоимости
                Random random = new Random();
                _secCost = _perSecond * (ulong)random.Next(90, 111) * _perClick * 10;
            }

            // разблокировка кнопки клика
            if (_money + _perClick > ulong.MaxValue)
                ClickButton.Enabled = true;

            // синхронизация
            MoneyLabel.Text = ToLetterConverter(_money) + " ☺";
            PerSecondLabel.Text = "В секунду: " + ToLetterConverter(_perSecond) + " ☺";
            SecCostLabel.Text = "Цена улучшения ☺ в секунду: " + ToLetterConverter(_secCost) + " ☺";
        }
    }
}
