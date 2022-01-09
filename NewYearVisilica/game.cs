using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewYearVisilica
{
    public partial class game : Form
    {
        string[] words;
        string currentWords;
        string showText;
        int lives;
        PictureBox[] lives_image;

        public game()
        {
            InitializeComponent();
            words = new string[] { "подарок", "гирлянда", "снег", "новый год", "сноуборд", "звезда",  };
            lives_image = new PictureBox[] { pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7 };
            lives = lives_image.Length;
            currentWords = "";
            showText = "";
            Start_Game(textBox1, lives_image);
        }
        bool is_contains(string word, char symbol)
        {
            foreach (char letter in word)
            {
                if (letter == symbol)
                {
                    return true;
                }

            }
            return false;
        }
        string get_show_text(string word)
        {
            string secret_word = "";
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] != ' ')
                {
                    secret_word += '*';
                }
                else
                {
                    secret_word += ' ';
                }
            }

            return secret_word;
        }
        void Start_Game(TextBox word_area)
        {
            Random random = new Random();
            int index = random.Next(0, words.Length);
            currentWords = words[index];
            showText = get_show_text(currentWords);
            word_area.Text = showText;
            lives = lives_image.Length;

        }


        void Start_Game(TextBox word_area, PictureBox[] image) 
        {
            Start_Game(word_area);
            foreach (PictureBox picture in image)
            {
                picture.Image = Properties.Resources.gift;
            }
        }

        string get_new_show_text(string word, char symbol, string old_show_text)
        {
            string result = "";
            for (int i = 0; i < word.Length; i++)
            {
                if (symbol == word[i])
                {
                    result += symbol;
                }
                else
                {
                    result += old_show_text[i];
                } 

            }
            return result;
        }

        void button_symbol_click(TextBox word_araea, char symboll, Button curbutton, Button startbutton)
        {
            bool contaner = is_contains(currentWords, symboll);
            if (contaner)
            {
                showText = get_new_show_text(currentWords, symboll, showText);
                word_araea.Text = showText;
            }
            else
            {
                lives--;
                lives_image[lives].Image = null;
            }
            curbutton.Enabled = false;
            if (currentWords == showText)
            {
                using (pobedaaaaa gameForm = new pobedaaaaa())
                {
                    gameForm.ShowDialog();
                }
            }
            else if(lives == 0)
            {
                using (proigral gameForm = new proigral())
                {
                    gameForm.ShowDialog();

                }
                startbutton.PerformClick();
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            Start_Game(textBox1, lives_image);
            Button[] knopki = new Button[] { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32, button33, button34, };
            foreach(var btn in knopki)
                btn.Enabled = true;
        }

        private void button34_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'а', button1, button33);

            
        }

        private void button34_MouseHover(object sender, EventArgs e)
        {
            
            //this.Width;
            //this.Height;

        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'б', button2, button33);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'в', button3, button33);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'г', button4, button33);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'д', button5, button33);
        }

      

        private void button7_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'ж', button7, button33);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'е', button35, button33);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'ё', button6, button33);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'з', button8, button33);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'и', button9, button33);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'й', button10, button33);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'к', button11, button33);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'л', button12, button33);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'м', button13, button33);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'н', button14, button33);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'о', button15, button33);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'п', button16, button33);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'р', button17, button33);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'с', button18, button33);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'т', button19, button33);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'у', button20, button33);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'ф', button21, button33);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'х', button22, button33);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'ц', button25, button33);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'ч', button27, button33);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'ш', button22, button33);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'щ', button24, button33);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'ъ', button26, button33);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'ы', button28, button33);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'ь', button29, button33);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'э', button30, button33);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'ю', button31, button33);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'я', button32, button33);
        }
    }
}
