using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doctor_sApp
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        public int C = 0;
        public int A = 0;
        public int I = 0;
        public int V = 0;
        public int F = 0;
        public int B = 0;
        public int P = 0;
        public int R = 0;
        public int L = 0;
        public int S = 0;
        public double Vd = 0.0;
        public double Vs = 0.0;

        public MainForm()
        {
            InitializeComponent();
            //реализация событий для кнопок "далее" и назад"
            //обработка события перехода на следующую вкладку, без этой строчки кода не робит кнопка
            this.Next_1st.Click += new System.EventHandler(this.Next_1st_Click);
            //кнопки далее для страниц дальше первой
            this.button1.Click += new System.EventHandler(this.button1_Click);
            //3я кнопка далее, хуй знает почему счёт сбился
            this.button3.Click += new System.EventHandler(this.button3_Click);
            //памагите
            this.button5.Click += new System.EventHandler(this.button5_Click);
            //таджики руляд
            this.button7.Click += new System.EventHandler(this.button7_Click);
            //
            this.button9.Click += new System.EventHandler(this.button9_Click);
            //
            this.button11.Click += new System.EventHandler(this.button11_Click);
            //
            this.button13.Click += new System.EventHandler(this.button13_Click);

            //с кнопками "Далее" всё, теперь пошли кнопки "Назад"

            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button6.Click += new System.EventHandler(this.button6_Click);
            this.button8.Click += new System.EventHandler(this.button8_Click);
            this.button10.Click += new System.EventHandler(this.button10_Click);
            this.button12.Click += new System.EventHandler(this.button12_Click);
            this.button14.Click += new System.EventHandler(this.button14_Click);
            //конец реализации
            MaximizeBox = false; //скрывает кнопку винды "полный экран"

            //чекбоксы, открывающие другие чекбоксы
        }

        //метод проверки симптомов, там через месседжбокс будет выводиться, какие пункты отметил врач
        public void Checking()
        {
            string result = "";
            bool crutch = true;

            //первая вкладка
            result += "Сбор жалоб:" + "\n";
            if (crutch == true)
            {
                if (checkBox1.Checked == true)
                {
                    result += checkBox1.Text + "\n";
                    crutch = false;
                }
                if (checkBox2.Checked == true)
                {
                    result += checkBox2.Text + "\n";
                    crutch = false;
                }
                if (checkBox3.Checked == true)
                {
                    result += checkBox3.Text + "\n";
                    crutch = false;
                }
                if (checkBox4.Checked == true)
                {
                    result += checkBox4.Text + "\n";
                    crutch = false;
                }
                if (checkBox5.Checked == true)
                {
                    result += checkBox5.Text + "\n";
                    crutch = false;
                }
                if (checkBox6.Checked == true)
                {
                    result += checkBox6.Text + "\n";
                    crutch = false;
                }
                if (checkBox7.Checked == true)
                {
                    result += checkBox7.Text + "\n";
                    crutch = false;
                }
                if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false && checkBox4.Checked == false && checkBox5.Checked == false && checkBox6.Checked == false
                    && checkBox7.Checked == false)
                {
                    crutch = false;
                }
                if (crutch == false)
                {
                    result += "\n";
                }
                crutch = true;
            }

            //вторая вкладка
            result += "Сбор анамнеза:" + "\n";
            if (crutch == true)
            {
                if (checkBox8.Checked == true)
                {
                    result += checkBox8.Text + "\n";
                    crutch = false;
                }
                if (checkBox9.Checked == true)
                {
                    result += checkBox9.Text + "\n";
                    crutch = false;
                }
                if (checkBox8.Checked == false && checkBox9.Checked == false)
                {
                    crutch = false;
                }
                if (crutch == false)
                {
                    result += "\n";
                }
                crutch = true;
            }

            //третья вкладка
            result += "Визуальный осмотр:" + "\n";
            if (crutch == true)
            {
                if (checkBox10.Checked == true)
                {
                    result += checkBox10.Text + "\n";
                    crutch = false;
                }
                if (checkBox11.Checked == true)
                {
                    result += checkBox11.Text + "\n";
                    crutch = false;
                }
                if (checkBox12.Checked == true)
                {
                    result += checkBox12.Text;
                    crutch = false;
                }
                if (checkBox13.Checked == true)
                {
                    result += checkBox13.Text + "\n";
                    crutch = false;
                }
                if (checkBox14.Checked == true)
                {
                    result += checkBox14.Text + "\n";
                    crutch = false;
                }
                if (checkBox15.Checked == true)
                {
                    result += checkBox15.Text + "\n";
                    crutch = false;
                }
                if (checkBox16.Checked == true)
                {
                    result += checkBox16.Text + "\n";
                    crutch = false;
                }
                if (checkBox10.Checked == false && checkBox11.Checked == false && checkBox12.Checked == false && checkBox13.Checked == false && checkBox14.Checked == false &&
                    checkBox15.Checked == false && checkBox16.Checked == false)
                {
                    crutch = false;
                }
                if (crutch == false)
                {
                    result += "\n";
                }
                crutch = true;
            }

            //четвертая вкладка
            result += "Визометрия:" + "\n";
            if (crutch == true)
            {
                if (checkBox17.Checked == true)
                {
                    result += "Левый глаз: " + textBox1.Text + "\n" + "Правый глаз: " + textBox2.Text + "\n";
                    crutch = false;
                }
                if (checkBox18.Checked == true)
                {
                    result += checkBox18.Text + "\n";
                    crutch = false;
                }
                if (checkBox19.Checked == true)
                {
                    result += checkBox19.Text + "\n";
                    crutch = false;
                }
                if (checkBox20.Checked == true)
                {
                    result += checkBox20.Text + "\n";
                    crutch = false;
                }
                if (checkBox21.Checked == true)
                {
                    result += checkBox21.Text + "\n";
                    crutch = false;
                }

                if (radioButton1.Checked == true)
                {
                    result += "Острота зрения: " + radioButton1.Text + "\n";
                    crutch = false;
                }
                if (radioButton2.Checked == true)
                {
                    result += "Острота зрения: " + radioButton2.Text + "\n";
                    crutch = false;
                }
                if (radioButton3.Checked == true)
                {
                    result += "Острота зрения: " + radioButton3.Text + "\n";
                    crutch = false;
                }
                if (checkBox17.Checked == false && checkBox18.Checked == false && checkBox19.Checked == false && checkBox20.Checked == false && checkBox21.Checked == false &&
                    radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false)
                {
                    crutch = false;
                }
                if (crutch == false)
                {
                    result += "\n";
                }
                crutch = true;
            }

            //пятая вкладка
            result += "Рефрактометрия:" + "\n";
            if (crutch == true)
            {
                if (checkBox22.Checked == true)
                {
                    result += checkBox22.Text + "\n";
                    crutch = false;
                }
                if (checkBox23.Checked == true)
                {
                    result += checkBox23.Text + "\n";
                    crutch = false;
                }
                if (checkBox24.Checked == true)
                {
                    result += checkBox24.Text + "\n";
                    crutch = false;
                }
                if (checkBox25.Checked == true)
                {
                    result += checkBox25.Text + "\n";
                    crutch = false;
                }
                if (checkBox26.Checked == true)
                {
                    result += checkBox26.Text + "\n";
                    crutch = false;
                }
                if (checkBox22.Checked == false && checkBox23.Checked == false && checkBox24.Checked == false && checkBox25.Checked == false && checkBox26.Checked == false)
                {
                    crutch = false;
                }
                if (crutch == false)
                {
                    result += "\n";
                }
                crutch = true;
            }

            //шестая вкладка
            result += "Биомикроскопия:" + "\n";
            if (checkBox27.Checked == true)
            {
                result += "Нейрофиброматоз век";
                if (checkBox28.Checked == true)
                {
                    result += ": Прогрессирующий рост";
                }

                if (checkBox29.Checked == true)
                {
                    result += "\n";
                }
                else
                {
                    result += "\n\n";
                }
            }

            if (checkBox29.Checked == true)
            {
                result += "Узелки Лиша";
                if (checkBox30.Checked == true)
                {
                    result += ": Прогрессирующий рост";
                }
                result += "\n\n";
            }

            if (checkBox27.Checked == false && checkBox29.Checked == false)
            {
                crutch = false;
            }
            if (crutch == false)
            {
                result += "\n";
            }
            crutch = true;

            //седьмая вкладка
            result += "Исследование полей зрения:" + "\n";
            if (crutch == true)
            {
                if (checkBox31.Checked == true)
                {
                    result += checkBox31.Text + "\n";
                    crutch = false;
                }
                if (checkBox32.Checked == true)
                {
                    result += checkBox32.Text + "\n";
                    crutch = false;
                }
                if (checkBox33.Checked == true)
                {
                    result += checkBox33.Text + "\n";
                    crutch = false;
                }
                if (checkBox31.Checked == false && checkBox32.Checked == false && checkBox33.Checked == false)
                {
                    crutch = false;
                }
                if (crutch == false)
                {
                    result += "\n";
                }
            }

            //восьмая вкладка
            result += "Осмотр глазного дна:" + "\n";
            //слева
            if (checkBox34.Checked == true)
            {
                result += checkBox34.Text + " (слева)" + "\n";
            }
            if (checkBox35.Checked == true)
            {
                result += checkBox35.Text + " (слева)" + "\n";
            }
            if (checkBox36.Checked == true)
            {
                result += checkBox36.Text + " (слева)" + "\n";
            }
            if (checkBox37.Checked == true)
            {
                result += checkBox37.Text + " (слева)" + "\n";
            }
            if (checkBox38.Checked == true)
            {
                result += checkBox38.Text + " (слева)" + "\n";
            }
            if (checkBox39.Checked == true)
            {
                result += checkBox39.Text + " (слева)" + "\n";
            }
            if (checkBox40.Checked == true)
            {
                result += checkBox40.Text + " (слева)" + "\n";
            }

            //справа
            if (checkBox41.Checked == true)
            {
                result += checkBox41.Text + " (справа)" + "\n";
            }
            if (checkBox42.Checked == true)
            {
                result += checkBox42.Text + " (справа)" + "\n";
            }
            if (checkBox43.Checked == true)
            {
                result += checkBox43.Text + " (справа)" + "\n";
            }
            if (checkBox44.Checked == true)
            {
                result += checkBox44.Text + " (справа)" + "\n";
            }
            if (checkBox45.Checked == true)
            {
                result += checkBox45.Text + " (справа)" + "\n";
            }
            if (checkBox46.Checked == true)
            {
                result += checkBox46.Text + " (справа)" + "\n";
            }
            if (checkBox47.Checked == true)
            {
                result += checkBox47.Text + " (справа)" + "\n";
            }
            DialogResult answer = MessageBox.Show(result + "\n" + "Всё верно?", "Проверка", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            if (answer == DialogResult.Yes)
            {
                button16.Enabled = true;
                button17.Enabled = false;
            }
        } 

        //метод, подсчитывающий все очки, и выводящий (но пока невыводящий) результат
        public void Result()
        {
            //первая вкладка
            if (checkBox1.Checked == true)
            {
                C = C + 1;
            }
            if (checkBox2.Checked == true)
            {
                C = C + 1;
            }
            if (checkBox3.Checked == true)
            {
                C = C + 1;
                S = 1;
            }
            if (checkBox4.Checked == true)
            {
                C = C + 1;
            }
            if (checkBox5.Checked == true)
            {
                C = C + 1;
            }
            if (checkBox6.Checked == true)
            {
                C = C + 1;
            }
            if (checkBox7.Checked == true)
            {
                C = C + 1;
            }

            //вторая вкладка
            if (checkBox8.Checked == true)
            {
                I = I + 1;
            }
            if (checkBox9.Checked == true)
            {
                I = I + 1;
            }

            //третья вкладка
            if (checkBox10.Checked == true)
            {
                I = I + 1;
            }
            if (checkBox11.Checked == true)
            {
                I = I + 1;
            }
            if (checkBox12.Checked == true)
            {
                I = I + 1;
            }
            if (checkBox13.Checked == true)
            {
                I = I + 1;
            }
            if (checkBox14.Checked == true)
            {
                I = I + 1;
            }
            if (checkBox15.Checked == true)
            {
                I = I + 1;
            }
            if (checkBox16.Checked == true)
            {
                I = I + 1;
            }

            //четвертая вкладка
            if (checkBox17.Checked == true)
            {
                Vs = Convert.ToDouble(textBox1.Text);
                Vd = Convert.ToDouble(textBox2.Text);
            }
            
            if (radioButton2.Checked == true)
            {
                V = V + 1;
            }
            if (radioButton3.Checked == true)
            {
                V = V + 2;
            }
            if (checkBox18.Checked == true)
            {
                V = V + 1;
            }
            if (checkBox19.Checked == true)
            {
                V = V + 1;
            }
            if (checkBox20.Checked == true)
            {
                V = V + 1;
            }
            if (checkBox21.Checked == true)
            {
                V = V + 1;
            }

            //пятая вкладка
            if (checkBox22.Checked == true)
            {
                F = F + 1;
            }
            if (checkBox23.Checked == true)
            {
                F = F + 1;
            }
            if (checkBox24.Checked == true)
            {
                F = F + 1;
            }
            if (checkBox25.Checked == true)
            {
                F = F + 1;
            }
            if (checkBox26.Checked == true)
            {
                F = F + 2;
            }

            //шестая вкладка
            if (checkBox27.Checked == true)
            {
                if (checkBox28.Checked == true)
                {
                    B = B + 2;
                }
                else
                {
                    B = B + 1;
                }
            }
            if (checkBox29.Checked == true)
            {
                if (checkBox30.Checked == true)
                {
                    B = B + 2;
                }
                else
                {
                    B = B + 1;
                }
            }

            //седьмая вкладка
            if (checkBox31.Checked == true)
            {
                P = P + 1;
            }
            if (checkBox32.Checked == true)
            {
                P = P + 1;
            }
            if (checkBox33.Checked == true)
            {
                P = P + 1;
            }

            //восьмая вкладка
            //левая часть
            if (checkBox34.Checked == true)
            {
                L = L + 1;
            }
            if (checkBox35.Checked == true)
            {
                L = L + 1;
            }
            if (checkBox36.Checked == true)
            {
                L = L + 1;
            }
            if (checkBox37.Checked == true)
            {
                L = L + 1;
            }
            if (checkBox38.Checked == true)
            {
                L = L + 1;
            }
            if (checkBox39.Checked == true)
            {
                L = L + 1;
            }
            if (checkBox40.Checked == true)
            {
                L = L + 1;
            }
            //правая часть
            if (checkBox41.Checked == true)
            {
                R = R + 1;
            }
            if (checkBox42.Checked == true)
            {
                R = R + 1;
            }
            if (checkBox43.Checked == true)
            {
                R = R + 1;
            }
            if (checkBox44.Checked == true)
            {
                R = R + 1;
            }
            if (checkBox45.Checked == true)
            {
                R = R + 1;
            }
            if (checkBox46.Checked == true)
            {
                R = R + 1;
            }
            if (checkBox47.Checked == true)
            {
                R = R + 1;
            }
        } 

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        //кнопки "далее"
        private void Next_1st_Click(object sender, EventArgs e)
        {
            this.TabControl.SelectedIndex = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.TabControl.SelectedIndex = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.TabControl.SelectedIndex = 3;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkBox17.Checked == true)
                {
                    Convert.ToDouble(textBox1.Text);
                    Convert.ToDouble(textBox2.Text);
                }
                this.TabControl.SelectedIndex = 4;
            }
            catch
            {
                MessageBox.Show("Введено неверное значение", "Ошибка!");
            }
            
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.TabControl.SelectedIndex = 5;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.TabControl.SelectedIndex = 6;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.TabControl.SelectedIndex = 7;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.TabControl.SelectedIndex = 8;
        }

        //кнопки "назад"
        private void button2_Click(object sender, EventArgs e)
        {
            this.TabControl.SelectedIndex = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.TabControl.SelectedIndex = 1;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.TabControl.SelectedIndex = 2;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.TabControl.SelectedIndex = 3;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.TabControl.SelectedIndex = 4;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.TabControl.SelectedIndex = 5;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.TabControl.SelectedIndex = 6;
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            this.TabControl.SelectedIndex = 7;
        }

        //это код, который делает активным второй чекбокс по нажатию на первый, и его деактивацию
        private void checkBox42_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox27.Checked == true)
            {
                checkBox28.Enabled = true;
            }
            if (checkBox27.Checked == false)
            {
                checkBox28.Enabled = false;
                checkBox28.Checked = false;
            }
        }

        //тоже
        private void CheckBox40_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox29.Checked == true)
            {
                checkBox30.Enabled = true;
            }
            if (checkBox29.Checked == false)
            {
                checkBox30.Enabled = false;
                checkBox30.Checked = false;
            }
        }

        //кнопка "проверка"
        private void Button17_Click(object sender, EventArgs e)
        {
            Checking();
        }

        //кнопка "результат"
        private void Button16_Click(object sender, EventArgs e)
        {
            Result();
        }

        //ну тут я немного сделал какаху, это где нужно вводить данные в текстбокс, я по дефолту сделал текстбоксы залочеными, а активацию их по нажатию на чекбокс (чтоб его не убирать и
        //не восстанавливать нумерацию)
        private void CheckBox17_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox17.Checked == true)
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                label13.Visible = true;
                label14.Visible = true;
                label15.Visible = true;
            }
            if (checkBox17.Checked == false)
            {
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                label13.Visible = false;
                label14.Visible = false;
                label15.Visible = false;
                textBox1.Clear();
                textBox2.Clear();
            }
        }
    }
}
