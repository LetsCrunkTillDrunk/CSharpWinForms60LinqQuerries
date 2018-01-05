using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 60; i++)
            {
                comboBox1.Items.Add(i+1);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox2.Text = "Linq Запрос";
            richTextBox3.Text = "Результат";
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;
            textBox4.Text = String.Empty;

            label2.Text = label7.Text = label3.Text = label4.Text = "Последовательность";
            
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    richTextBox1.Text = "Дана целочисленная последовательность, содержащая как положительные числа, так и отрицательные. Вывести первое положительное число и последнее отрицательное";
                    textBox2.Enabled = false;
                    break;
                case 1:
                    richTextBox1.Text = "Дана целочисленная последовательность и число D. Вывести первый положительный элемент, оканчивающийся цифрой D. Если такого элемента нет - вывести 0";
                    label4.Text = "Число D";
                    break;
                case 2:
                    richTextBox1.Text = "Дано целое положительное число L и строковая последовательность. Найти последнюю строку, которая начинается с цифры и имеющую длину L. Если подходящих строк нет - вывести \"Not Found\"";
                    label4.Text = "Число L";
                    break;
                case 3:
                    richTextBox1.Text = "Дана строковая последовательность и символ С. Если последовательность содержит единственный элемент, заканчивающийся символом С - вывести его. Если элементов больше одного - вывести \"Error\". Вывести пустую строку, если таких элементов нет ";
                    label4.Text = "Символ С";
                    break;
                case 4:
                    richTextBox1.Text = "Дана строковая последовательность и символ С. Найти количество элементов, чья длина больше единицы и которые начинаются и заканчиваются символом С";
                    label4.Text = "Символ С";
                    break;
                case 5:
                    richTextBox1.Text = "Дана строковая последовательность, найти сумму длин всех элементов";
                    textBox2.Enabled = false;
                    break;
                case 6:
                    richTextBox1.Text = "Дана целочисленная последовательность. Найти количество и сумму всех отрицательных элементов";
                    textBox2.Enabled = false;
                    break;
                case 7:
                    richTextBox1.Text = "Дана целочисленная последовательность. Найти количество ее положительных двузначных элементов и их среднеарифметическое";
                    textBox2.Enabled = false;
                    break;
                case 8:
                    richTextBox1.Text = "Вывести минимальный положительный элемент";
                    textBox2.Enabled = false;
                    break;
                case 9:
                    richTextBox1.Text = "Дана строковая последовательность и число L. Вывести наибольшую строку лексикографического порядка с длиной L";
                    label4.Text = "Число L";
                    break;
                case 10:
                    richTextBox1.Text = "Дана строковая последовательность. Вывести строку, состоящую из начальных символов всех элементов";
                    textBox2.Enabled = false;
                    break;
                case 11:
                    richTextBox1.Text = "Дана целочисленная последовательность. Найти произведение последних цифр всех элементов";
                    textBox2.Enabled = false;
                    break;
                case 12:
                    richTextBox1.Text = "Дано положительное число N. Найти его сумму в формате 1 + 1/2 + 1/N";
                    textBox1.Enabled = false;
                    label4.Text = "Число N";
                    break;
                case 13:
                    {
                        richTextBox1.Text = "Даны два числа, A < B, найти среднеарифметическое квадратов всех чисел между ними включительно";
                        label3.Text = "Число A";
                        label4.Text = "Число B";
                        break;
                    }
                case 14:
                    {
                        richTextBox1.Text = "Найти факториал числа N";
                        textBox1.Enabled = false;
                        label4.Text = "Число N";
                        break; 
                    }
                case 15:
                    {
                        richTextBox1.Text = "Дана целочисленная последовательность. Извлечь из нее все положительные числа";
                        textBox2.Enabled = false;
                        break;
                    }
                case 16:
                    {
                        richTextBox1.Text = "Дана целочисленная последовательность. Извлечь из нее все нечетные числа, удалив все дубликаты";
                        textBox2.Enabled = false;
                        break;
                    }
                case 17:
                    {
                        richTextBox1.Text = "Дана целочисленная последовательность. Извлечь из нее все четные отрицательные числа, поменяв порядок следования на обратный";
                        textBox2.Enabled = false;
                        break;
                    }
                case 18:
                    {
                        richTextBox1.Text = "Дано однозначное число D и целочисленная последовательность. Извлечь из А все положительные числа оканчивающиеся на D. Удалить все повторения";
                        label4.Text = "Число D";
                        break;
                    }
                case 19:
                    {
                        richTextBox1.Text = "Дана целочисленная последовательность. Извлечь из нее все положительные двузначные числа. Отсортировать по возрастанию";
                        textBox2.Enabled = false;
                        break;
                    }
                case 20:
                    {
                        richTextBox1.Text = "Дана строковая последовательность. Отсортировать строки по длине. В случае одинаковый длины - в лексикографическом порядке";
                        textBox2.Enabled = false;
                        break;
                    }
                case 21:
                    {
                        richTextBox1.Text = "Дана строковая последовательность и число К. Извлечь из последовательности все элементы длины К, которые заканчиваются цифрой. Отсортировать лексикографически по возрастанию";
                        label4.Text = "Число K";
                        break;
                    }
                case 22:
                    {
                        richTextBox1.Text = "Дана целочисленная последовательность и число К. Начиная с числа послеовательности под порядковым номером К, извлечь из последовательности все нечетные двузначные числа. Отсортировать по убыванию";
                        label4.Text = "Число K";
                        break;
                    }
                case 23:
                    {
                        richTextBox1.Text = "Дана строковая последовательность и число К. Извлечь из последовательности элементы, которые предшествуют элементу с порядковым номером К. Выбрать из них сторки нечетной длины, которые начинаются с буквы, изменив порядок следования на обратный";
                        label4.Text = "Число К";
                        break;
                    }
                case 24:
                    {
                        richTextBox1.Text = "Дана целочисленная последовательсть и числа К1 и К2. 1 < K1 < K2 < Длина последовательности. Вывести сумму положительных элементов между порядковыми номерами К1 и К2 включительно";
                        label4.Text = "Число К1";
                        label2.Text = "Число К2";
                        textBox4.Enabled = true;
                        break;
                    }
                case 25:
                    {
                        richTextBox1.Text = "Дана строковая последовательность и числа К1 и К2. 1 < K1 < K2 < Длина последовательности. Вывести среднеарифметическое всех длин элементов за вычетом элементов последовательности между порядковыми номерами К1 и К2";
                        label4.Text = "Число К1";
                        label2.Text = "Число К2";
                        textBox4.Enabled = true;
                        break;
                    }
                case 26:
                    {
                        richTextBox1.Text = "Дана целочисленная последовательность и число D. Начиная с первого элемента большего чем число D, извлечь все положительные нечетные элементы поменяв порядок на обратный";
                        label4.Text = "Число D";
                        break;
                    }
                case 27:
                    {
                        richTextBox1.Text = "Дана строковая последовательность и число L. Из элементов последовательности, предшествующих элементу, длина которого больше L, извлечь строки, оканчивающиеся буквой. Последовательность отсортировать по убвыанию длины строк. А строки одинаковой длины - в лексикографическом порядке по возрастанию";
                        label4.Text = "Число L";
                        break;
                    }
                case 28:
                    {
                        richTextBox1.Text = "Дана целочисленная последовательность и числа D и К. Найти теоретико-множественно объединение двух фрагментов последовательности. Первый содержит все элементы, до элемента большего чем D. Второй - все элементы начиная с порядкового номера K. Убрать из последовательности повторяющиеся элементы и отсортировать по убыванию";
                        label4.Text = "Число D";
                        label2.Text = "Число К";
                        textBox4.Enabled = true;
                        break;
                    }
                case 29:
                    {
                        richTextBox1.Text = "Дана целочисленная последовательность и число К. Найти теоретико-множественную разность между двумя фрагментами. Первый содержит все четные числа. Второй все числа, с порядковыми номерами больше K. В последовательности поменять порядок элементов на обратный";
                        label4.Text = "Число K";
                        break;
                    }
                case 30:
                    {
                        richTextBox1.Text = "Дана строковая последовательность и число K. Найти теоретико-множественное пересечение двух фрагментов. Первый содержит К начальных элементов. Второй - все элементы, после последнего элемента оканчивающегося цифрой. Убрать дубликаты. Полученную последовательность отсортировать во возрастанию длин строк, а строки одинаковой длины - в лексикографическом порядке";
                        label4.Text = "Число K";
                        break;
                    }
                case 31:
                    {
                        richTextBox1.Text = "Дана строковая последовательность. Получить последовательность символов, которая соответствует первому символу строковой последовательности. Вывести в обратном порядке";
                        textBox2.Enabled = false;
                        break;
                    }
                case 32:
                    {
                        richTextBox1.Text = "Дана целочисленная послеовательность. Обрабатывая только положительные числа, получить последовательность только из последних цифр элементов. Удалить из последовательности все совпадения, кроме первого";
                        textBox2.Enabled = false;
                        break;
                    }
                case 33:
                    {
                        richTextBox1.Text = "Дана последовательность положительных целых чисел. Обрабатывая только нечетные числа, получить их строковое представление и отсортировать в лексикографическом порядке";
                        textBox2.Enabled = false;
                        break;
                    }
                case 34:
                    {
                        richTextBox1.Text = "Дана целочисленная последовательность. Получить из нее последовательность, которая равна произведению значения элемента на его порядковый номер. В полученной последовательности удалить все элементы, не являющиеся двузначными и поменять порядок на обратный";
                        textBox2.Enabled = false;
                        break;
                    }
                case 35:
                    {
                        richTextBox1.Text = "Дана строковая последовательность. Получить последовательность символов, которая определяется таким образом. Если длина строки нечетная, в качестве символа берется первый символ этой строки. Если четная - последний. Отсортировтаь по убыванию";
                        textBox2.Enabled = false;
                        break;
                    }
                case 36:
                    {
                        richTextBox1.Text = "Дана строковая последовательность. Получить из нее новую последовательность путем добавления в конец строки ее порядкового номера";
                        textBox2.Enabled = false;
                        break;
                    }
                case 37:
                    {
                        richTextBox1.Text = "Дана целочисленная последовательность. Получить новую последовательность по принципу: если элемент делится на 3 без остатка - элемент в последовательность не включается, если остаток 1 - то в последовательность добавляется удвоенное значение элемента, если 2 - элемент включается в последовательность без изменений ";
                        textBox2.Enabled = false;
                        break;
                    }
                case 38:
                    {
                        richTextBox1.Text = "Дана строковая последовательность. Получить из нее последовательность числовых символов";
                        textBox2.Enabled = false;
                        break;
                    }
                case 39:
                    {
                        richTextBox1.Text = "Дана строковая последовательность и число К. Получить все символы всех строк длина которых равна или больше К. Порядок поменять на обратный";
                        label4.Text = "Число К";
                        break;
                    }
                case 40:
                    {
                        richTextBox1.Text = "Дана строковая последовательность и число К. Каждый элемент последовательности представляет из себя несколько слов, разделенных символом точки \'.\'Получить последовательность строк из элементов длины К ";
                        label4.Text = "Число К";
                        break;
                    }
                case 41:
                    {
                        richTextBox1.Text = "Дана строковая последовтаельность. Получить последовательность символов, определяющихся следующим образом. Для строк с нечетным порядковым номером получить все прописные символы, для строк с четным порядковым номером - все заглавные";
                        textBox2.Enabled = false;
                        break;
                    }
                case 42:
                    {
                        richTextBox1.Text = "Дана строковая последовательность и число К. Получить последовательность символов. Для первых К элементов последовательность должна содержать символы стоящие в нечетных позициях, для остальных в четных. Поменять порядок на обратный";
                        label4.Text = "Число К";
                        break;
                    }
                case 43:
                    {
                        richTextBox1.Text = "Даны целочисленные последовательности А и В, а также числа К1 и К2. Получить последовательность, которая содержит все числа из А больше К1 и все числа из В меньше К2";
                        label3.Text = "Последовательность А";
                        label4.Text = "Последовательность В";
                        label2.Text = "Число К1";
                        label7.Text = "Число К2";
                        textBox3.Enabled = true;
                        textBox4.Enabled = true;
                        break;
                    }
                case 44:
                    {
                        richTextBox1.Text = "Даны строковые последовательности А и В и числа L1 и L2. Получить последовательность, которая содержит все строки длины L1 из А и длины L2 из В. Отсортировать по убыванию в лексикографическом порядке";
                        label3.Text = "Последовательность А";
                        label4.Text = "Последовательность В";
                        label2.Text = "Число L1";
                        label7.Text = "Число L2";
                        textBox3.Enabled = true;
                        textBox4.Enabled = true;
                        break;
                    }
                case 45:
                    {
                        richTextBox1.Text = "Даны две числовые последовательности А и В, содержащие различные элементы. Найти последовательность, которая удовлетворяют следующему условию: оба элемента оканчиваются одной и той же цифрой. Записать результат в виде строки, где пары элементов разделены дефисом";
                        label3.Text = "Последовательность А";
                        label4.Text = "Последовательность В";
                        break;
                    }
                case 46:
                    {
                        richTextBox1.Text = "Даны две числовые последовательности А и В, содержащие различные элементы. Найти последовательность, которая удовлетворяет следующему условию: последняя цифра элемента последовательности А равна первой цифре элемента последовательности В. Записать результат в виде строки, где пары элементов разделены двоеточием";
                        label3.Text = "Последовательность А";
                        label4.Text = "Последовательность В";
                        break;
                    }
                case 47:
                    {
                        richTextBox1.Text = "Даны две строковые последовательности А и В. Найти последовательность, которая содержит элементы из А и В, имеющие одинаковую длину. Результат записать в виде строки, содержащей элементы из А и В, разделенные двоеточием";
                        label3.Text = "Последовательность А";
                        label4.Text = "Последовательность В";
                        break;
                    }
                case 48:
                    {
                        richTextBox1.Text = "Даны строковые послеовательности А, В и С. Найти последовательность, которая содержит строки, начинающиеся с одинакового симола всех трех последовательностей. Результат записать в виде строки, разделенной знаком равно";
                        label3.Text = "Последовательность А";
                        label4.Text = "Последовательность В";
                        label2.Text = "Последовательность С";
                        textBox4.Enabled = true;
                        break;
                    }
                case 49:
                    {
                        richTextBox1.Text = "Даны строковые последовательности А и В. Получить последовательность вида \"Е:N\", где Е - элемент последовательности А, N - количество элементов последовательности B, которые начинаются с того же символа";
                        label3.Text = "Последовательность А";
                        label4.Text = "Последовательность В";
                        break;
                    }
                case 50:
                    {
                        richTextBox1.Text = "Даны две целочисленные последовательности А и В. Послучить последовательность формата \"S:E\", где S - сумма элементов последовательности В, которые оканчиваются на ту же цифру, что и элемент последовательности А, Е - элемент последовательности А";
                        label3.Text = "Последовательность А";
                        label4.Text = "Последовательность В";
                        break;
                    }
                case 51:
                    {
                        richTextBox1.Text = "Даны две целочисленные последовательности А и В. Послучить последовательность вида \"Е1 = Е2\", где Е1 - строка, заканчивающаяся числом их последовательности А, Е2 - строка, заканчивающаяся числом из последовательности В";
                        label3.Text = "Последовательность А";
                        label4.Text = "Последовательность В";
                        break;
                    }
                case 52:
                    {
                        richTextBox1.Text = "Даны целочисленные последовательности А и В. Получить последовательность всех различных сумм элементов из А и В. Упорядочить по возрастанию";
                        label3.Text = "Последовательность А";
                        label4.Text = "Последовательность В";
                        break;
                    }
                case 53:
                    {
                        richTextBox1.Text = "Даны две строковые последовательности А и В. Найти последовательность всех пар строк, удовлетворяющих следующему условию. Первый элемент пары принадлежит последовательности А. А второй является либо элементом В, начинающимся с того же символа, что и элемент последовательности А, либо пустой строкой. Представить получившийся элемент в виде \"Е1.Е2\"";
                        label3.Text = "Последовательность А";
                        label4.Text = "Последовательность В";
                        break;
                    }
                case 54:
                    {
                        richTextBox1.Text = "Даны числовые последовательности А и В. Найти левое внешнее объединение, пары в котором должны удовлетворять следующему условию - оба элемента пары оканчиваются одной и той же цифрой. Представить результат в виде \"Е1:E2\", где Е1 -число из А, а Е2 - число из В. или 0, если таких элементов в последовательности нет";
                        label3.Text = "Последовательность А";
                        label4.Text = "Последовательность В";
                        break;
                    }
                case 55:
                    {
                        richTextBox1.Text = "Дана целочисленная последовательность. Сгруппировать элементы на основе последней цифры. Получить последовательность строк вида\"D:S\", где D - ключ группировки, S - сумма элементов";
                        textBox2.Enabled = false;
                        break;
                    }
                case 56:
                    {
                        richTextBox1.Text = "Дана целочисленная последовательность. Среди всех элементов, оканчивающихся одной и той же цифрой выбрать максимальный";
                        textBox2.Enabled = false;
                        break;
                    }
                case 57:
                    {
                        richTextBox1.Text = "Дана последовательность строк. Упорядочить их по длине. Если среди строк встречаются строки одинаковый длины, выбрать первую по порядку следования. Упорядочить по возрастанию";
                        textBox2.Enabled = false;
                        break;
                    }
                case 58:
                    {
                        richTextBox1.Text = "Дана строковая последовательность. Сгруппировать по длине, в случае одинаковой длины, выбрать ту строку, которая идет первой в лексикографическом порядке по возрастанию. Полученную последовательность отсортировтаь по убывнию длин";
                        textBox2.Enabled = false;
                        break;
                    }
                case 59:
                    {
                        richTextBox1.Text = "Дана строковая последовательность. Для всех строк, которые начинаются с одинаковой буквы определить их суммарную длину и записать в виде S-C, где S - суммарная длина, а С - буква. Остортировать по убыванию сумм. А в случае равенства - по возрастанию кодов символов";
                        textBox2.Enabled = false;
                        break;
                    }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 0) return;
            if (textBox1.Text == String.Empty && textBox2.Text == String.Empty) return;
            string[] str1 = textBox1.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            try
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        {
                            IEnumerable<int> ints = ConvertToInt(str1);
                            int ans = ints.First(i => i > 0);
                            int ans1 = ints.Last(i => i < 0);
                            richTextBox3.Text = ans + " " + ans1;
                            richTextBox2.Text = "First(i => i > 0), Last(i => i < 0) ";
                            break;
                        }
                    case 1:
                        {
                            IEnumerable<int> ints = ConvertToInt(str1);
                            if (textBox2.Text == String.Empty) return;
                            int digit = Convert.ToInt32(textBox2.Text);
                            int ans = ints.FirstOrDefault(i => i > 0 && i % 10 == digit);
                            richTextBox3.Text = ans.ToString();
                            richTextBox2.Text = "FirstOrDefault(i => i > 0 && i % 10 == digit)";
                            break;
                        }
                    case 2:
                        {
                            if (textBox2.Text == String.Empty) return;
                            int digit = Convert.ToInt32(textBox2.Text);
                            string ans = str1.LastOrDefault(i => Char.IsDigit(i[0]) && i.Length == digit) ?? "No Match";
                            richTextBox3.Text = ans;
                            richTextBox2.Text = "LastOrDefault(i => Char.IsDigit(i[0]) && i.Length == digit) ?? \"No Match\"";
                            break;
                        }
                    case 3:
                        {
                            try
                            {
                                if (textBox2.Text == String.Empty) return;
                                char c = Convert.ToChar(textBox2.Text);
                                string ans = str1.SingleOrDefault(i => i[i.Length - 1] == c) ?? "";
                                richTextBox3.Text = ans;
                                richTextBox2.Text = "SingleOrDefault(i => i[i.Length - 1] == c) ?? \"\"";
                            }
                            catch (InvalidOperationException ioe)
                            {
                                richTextBox3.Text = "Error";
                            }
                            break;
                        }
                    case 4:
                        {
                            if (textBox2.Text == String.Empty) return;
                            char c = Convert.ToChar(textBox2.Text);
                            int ans = str1.Where(i => i.Length > 1 && i[0] == c && i[i.Length - 1] == c).Count();
                            richTextBox3.Text = ans.ToString();
                            richTextBox2.Text = "Where(i => i.Length > 1 && i[0] == c && i[i.Length - 1] == c).Count()";
                            break;
                        }
                    case 5:
                        {
                            int ans = str1.Sum(i => i.Length);
                            richTextBox3.Text = ans.ToString();
                            richTextBox2.Text = "Sum(i => i.Length)";
                            break;
                        }
                    case 6:
                        {
                            IEnumerable<int> ints = ConvertToInt(str1);
                            int ans1 = ints.Where(i => i < 0).Count();
                            int ans2 = ints.Where(i => i < 0).Sum();
                            richTextBox3.Text = "Количество: " + ans1 + " Сумма: " + ans2;
                            richTextBox2.Text = "Where(i => i < 0).Count() + Where(i => i < 0).Sum()";
                            break;
                        }
                    case 7:
                        {
                            IEnumerable<int> ints = ConvertToInt(str1);
                            int ans1 = ints.Where(i => i > 9 && i < 100).Count();
                            double ans2 = ints.Where(i => i > 9 && i < 100).Average();
                            richTextBox3.Text = "Количество: " + ans1 + " Среднее: " + ans2;
                            richTextBox2.Text = "Where(i => i > 9 && i < 100).Count() + Where(i => i > 9 && i < 100).Average()";
                            break;
                        }
                    case 8:
                        {
                            try
                            {
                                IEnumerable<int> ints = ConvertToInt(str1);
                                int ans = ints.Where(i => i > 0).Min();
                                richTextBox3.Text = "Минимальный положительный элемент: " + ans.ToString();
                                richTextBox2.Text = "Where(i => i > 0).Min()";
                            }
                            catch (Exception e1)
                            {
                                richTextBox3.Text = 0.ToString();
                            }
                            break;
                        }
                    case 9:
                        {
                            try
                            {
                                if (textBox2.Text == String.Empty) return;
                                int len = Convert.ToInt16(textBox2.Text);
                                string ans = str1.Where(i => i.Length == len).Max();
                                richTextBox3.Text = ans;
                                richTextBox2.Text = "Where(i => i.Length == len).Max()";
                            }
                            catch (Exception)
                            {
                                richTextBox3.Text = " ";
                            }
                            break;
                        }
                    case 10:
                        {
                            string ans = str1.Aggregate("",(a, i) => a + i[0]);
                            richTextBox3.Text = ans;
                            richTextBox2.Text = "Aggregate(\"\", (a, i) => a + i[0])";
                            break;
                        }
                    case 11:
                        {
                            double ans = str1.Aggregate<string, double>(1, (a,i)=> a * Convert.ToInt64(i[i.Length-1]-'0'));
                            richTextBox3.Text = ans.ToString();
                            richTextBox2.Text = "Aggregate<string, double>(1, (a,i)=> a * Convert.ToInt64(i[i.Length-1]-'0'))";
                            break;
                        }
                    case 12:
                        {
                            if (textBox2.Text == String.Empty) return;
                            int digit = Convert.ToInt32(textBox2.Text);
                            double ans = Enumerable.Range(1, digit).Select(i => 1 /(double) i).Sum();
                            richTextBox3.Text = ans.ToString();
                            richTextBox2.Text = "Enumerable.Range(1, digit).Select(i => 1 / (double)i).Sum()";
                            break;
                        }
                    case 13:
                        {
                            if (textBox2.Text == String.Empty || textBox1.Text == String.Empty) return;
                            int digit1 = Convert.ToInt32(textBox1.Text);
                            int digit2 = Convert.ToInt32(textBox2.Text);
                            double ans = Enumerable.Range(digit1, digit2-digit1+1).Select(i => i * i).Average();
                            richTextBox3.Text = ans.ToString();
                            richTextBox2.Text = "Enumerable.Range(digit1, digit2-digit1+1).Select(i => i * i).Average()";
                            break;
                        }
                    case 14:
                        {
                            if (textBox2.Text == String.Empty) return;
                            int digit = Convert.ToInt32(textBox2.Text);
                            double ans = Enumerable.Range(1, digit).Aggregate(1, (a, i) => a * i);
                            richTextBox3.Text = ans.ToString();
                            richTextBox2.Text = "Enumerable.Range(1, digit).Aggregate(1, (a, i) => a * i)";
                            break;
                        }
                    case 15:
                        {
                            IEnumerable<int> ints = ConvertToInt(str1);
                            IEnumerable<string> strings = ints.Where(i => i > 0).Select(i=> i.ToString());
                            PrintInLabelBox(strings);
                            richTextBox2.Text = "Where(i => i > 0).Select(i=> i.ToString())";
                            break;
                        }
                    case 16:
                        {
                            IEnumerable<int> ints = ConvertToInt(str1);
                            IEnumerable<string> strings = ints.Where(i => i % 2 != 0).Distinct().Select(i => i.ToString());
                            PrintInLabelBox(strings);
                            richTextBox2.Text = "Where(i => i % 2 != 0).Distinct().Select(i => i.ToString())";
                            break;
                        }
                    case 17:
                        {
                            IEnumerable<int> ints = ConvertToInt(str1);
                            IEnumerable<string> strings = ints.Where(i => i % 2 == 0 && i < 0).Reverse().Select(i => i.ToString());
                            PrintInLabelBox(strings);
                            richTextBox2.Text = "Where(i => i % 2 == 0 && i < 0).Reverse().Select(i => i.ToString()";
                            break;
                        }
                    case 18:
                        {
                            if (textBox2.Text == String.Empty) return;
                            char c = Convert.ToChar(textBox2.Text);
                            IEnumerable<string> strings = str1.Where(i => i[i.Length - 1] == c && i[0] != '-').Distinct();
                            PrintInLabelBox(strings);
                            richTextBox2.Text = "Where(i => i[i.Length - 1] == c && i[0] != '-').Distinct()";
                            break;
                        }
                    case 19:
                        {
                            IEnumerable<int> ints = ConvertToInt(str1);
                            IEnumerable<string> strings = ints.Where(i => i > 9 && i < 100).OrderBy(i => i).Select(i => i.ToString());
                            PrintInLabelBox(strings);
                            richTextBox2.Text = "Where(i => i > 9 && i < 100).OrderBy(i => i).Select(i => i.ToString())";
                            break;
                        }
                    case 20:
                        {
                            IEnumerable<string> strings = str1.OrderBy(i => i.Length).ThenBy(i => i);
                            PrintInLabelBox(strings);
                            richTextBox2.Text = "OrderBy(i => i.Length).ThenBy(i => i)";
                            break;
                        }
                    case 21:
                        {
                            if (textBox2.Text == String.Empty) return;
                            int digit = Convert.ToInt32(textBox2.Text);
                            IEnumerable<string> strings = str1.Where(i => i.Length == digit && Char.IsDigit(i[i.Length - 1])).OrderBy(i => i);
                            PrintInLabelBox(strings);
                            richTextBox2.Text = "Where(i => i.Length == digit && Char.IsDigit(i[i.Length - 1])).OrderBy(i => i)";
                            break;
                        }
                    case 22:
                        {
                            if (textBox2.Text == String.Empty) return;
                            int digit = Convert.ToInt32(textBox2.Text);
                            IEnumerable<int> ints = ConvertToInt(str1);
                            IEnumerable<string> strings = ints.Skip(digit-1).Where(i => i % 2 != 0 && i > 9 && i < 100).Select(i => i.ToString());
                            PrintInLabelBox(strings);
                            richTextBox2.Text = "Skip(digit-1).Where(i => i % 2 != 0 && i > 9 && i < 100).Select(i => i.ToString())"; 
                            break;
                        }
                    case 23:
                        {
                            if (textBox2.Text == String.Empty) return;
                            int digit = Convert.ToInt32(textBox2.Text);
                            IEnumerable<string> strings = str1.Take(digit-1).Where(i => i.Length % 2 != 0 && Char.IsLetter(i[0])).Reverse();
                            PrintInLabelBox(strings);
                            richTextBox2.Text = "Take(digit-1).Where(i => i.Length % 2 != 0 && Char.IsLetter(i[0])).Reverse()";
                            break;
                        }
                    case 24:
                        {
                            if (textBox2.Text == String.Empty) return;
                            if (textBox4.Text == String.Empty) return;
                            int digit1 = Convert.ToInt32(textBox2.Text);
                            int digit2 = Convert.ToInt32(textBox4.Text);
                            IEnumerable<int> ints = ConvertToInt(str1);
                            int answer = ints.Skip(digit1-1).Take(digit2-digit1+1).Where(i => i > 0).Sum();
                            richTextBox3.Text = "Сумма = " + answer;
                            richTextBox2.Text = "Skip(digit1-1).Take(digit2-digit1+1).Where(i => i > 0).Sum()";
                            break;
                        }
                    case 25:
                        {
                            if (textBox2.Text == String.Empty) return;
                            if (textBox4.Text == String.Empty) return;
                            int digit1 = Convert.ToInt32(textBox2.Text);
                            int digit2 = Convert.ToInt32(textBox4.Text);
                            double ans = str1.Take(digit1-1).Concat(str1.Skip(digit2)).Select(i => i.Length).Average();
                            richTextBox3.Text = "Средняя длина = " + ans;
                            richTextBox2.Text = "Take(digit1-1).Concat(str1.Skip(digit2)).Select(i => i.Length).Average();";
                            break;
                        }
                    case 26:
                        {
                            if (textBox2.Text == String.Empty) return;
                            int digit = Convert.ToInt32(textBox2.Text);
                            IEnumerable<int> ints = ConvertToInt(str1);
                            IEnumerable<string> strings = ints.SkipWhile(i => i <= digit).Where(i => i > 0 && i % 2 != 0).Reverse().Select(i => i.ToString());
                            PrintInLabelBox(strings);
                            richTextBox2.Text = "SkipWhile(i => i <= digit).Where(i => i > 0 && i % 2 != 0).Reverse().Select(i => i.ToString())";
                            break;
                        }
                    case 27:
                        {
                            if (textBox2.Text == String.Empty) return;
                            int digit = Convert.ToInt32(textBox2.Text);
                            IEnumerable<string> strings = str1.TakeWhile(i => i.Length < digit).Where(i => Char.IsLetter(i[i.Length-1])).OrderByDescending(i => i.Length).ThenBy(i => i);
                            PrintInLabelBox(strings);
                            richTextBox2.Text = "TakeWhile(i => i.Length < digit).Where(i => Char.IsLetter(i[i.Length-1])).OrderByDescending(i => i.Length).ThenBy(i => i)";
                            break;
                        }
                    case 28:
                        {
                            if (textBox2.Text == String.Empty) return;
                            if (textBox4.Text == String.Empty) return;
                            int digit1 = Convert.ToInt32(textBox2.Text);
                            int digit2 = Convert.ToInt32(textBox4.Text);
                            IEnumerable<int> ints = ConvertToInt(str1);
                            IEnumerable<string> strings = ints.TakeWhile(i => i < digit1).Concat(ints.Skip(digit2 - 1)).Distinct().OrderByDescending(i => i).Select(i => i.ToString());
                            PrintInLabelBox(strings);
                            richTextBox2.Text = "TakeWhile(i => i < digit1).Concat(ints.Skip(digit2 - 1)).Distinct().OrderByDescending(i => i).Select(i => i.ToString())";
                            break;
                        }
                    case 29:
                        {
                            if (textBox2.Text == String.Empty) return;
                            int digit = Convert.ToInt32(textBox2.Text);
                            IEnumerable<int> ints = ConvertToInt(str1);
                            IEnumerable<string> strings = ints.Where(i => i % 2 == 0).Except(ints.SkipWhile((i, index) => index <= digit)).Distinct().Reverse().Select(i => i.ToString());
                            PrintInLabelBox(strings);
                            richTextBox2.Text = "Where(i => i % 2 == 0).Except(ints.SkipWhile((i, index) => index <= digit)).Distinct().Reverse().Select(i => i.ToString())";
                            break;
                        }
                    case 30:
                        {
                            if (textBox2.Text == String.Empty) return;
                            int digit = Convert.ToInt32(textBox2.Text);
                            IEnumerable<string> strings = str1.Take(digit).Intersect(str1.Reverse().TakeWhile(i => !Char.IsDigit(i[i.Length-1]))).Distinct().OrderBy(i => i.Length).ThenBy(i => i);
                            PrintInLabelBox(strings);
                            richTextBox2.Text = "Take(digit).Intersect(str1.Reverse().TakeWhile(i => !Char.IsDigit(i[i.Length-1]))).Distinct().OrderBy(i => i.Length).ThenBy(i => i)";
                            break;
                        }
                    case 31:
                        {
                            IEnumerable<char> chars = str1.Select(i => Convert.ToChar(i[0])).Reverse();
                            PrintChars(chars);
                            richTextBox2.Text = "Select(i => Convert.ToChar(i[0])).Reverse()";
                            break;
                        }
                    case 32:
                        {
                            IEnumerable<string> strings = str1.Where(i => i[0] != '-').Select(i => Convert.ToInt32(i[i.Length - 1] - '0')).Distinct(new AlmostDistinct()).Select(i => i.ToString());
                            PrintInLabelBox(strings);
                            richTextBox2.Text = "Where(i => i[0] != '-').Select(i => Convert.ToInt32(i[i.Length - 1] - '0')).Distinct(new AlmostDistinct()).Select(i => i.ToString()) + Простенький компаратор";
                            break;
                        }
                    case 33:
                        {
                            IEnumerable<int> ints = ConvertToInt(str1);
                            IEnumerable<string> strings = ints.Where(i => i % 2 != 0).Select(i => i.ToString()).OrderBy(i => i);
                            PrintInLabelBox(strings);
                            richTextBox2.Text = "Where(i => i % 2 != 0).Select(i => i.ToString()).OrderBy(i => i)";
                            break;
                        }
                    case 34:
                        {
                            IEnumerable<int> ints = ConvertToInt(str1);
                            IEnumerable<string> strings = ints.Select((i, index) => i * index).Where(i => i > 9 && i < 100).Reverse().Select(i => i.ToString());
                            PrintInLabelBox(strings);
                            richTextBox2.Text = "Select((i, index) => i * index).Where(i => i > 9 && i < 100).Reverse().Select(i => i.ToString())";
                            break;
                        }
                    case 35:
                        {
                            IEnumerable<char> chars = str1.Select(i => i.Length % 2 == 0 ? Convert.ToChar(i[i.Length - 1]) : i[0]).OrderByDescending(i => i);
                            PrintChars(chars);
                            richTextBox2.Text = ".Select(i => i.Length % 2 == 0 ? Convert.ToChar(i[i.Length - 1]) : i[0]).OrderByDescending(i => i)";
                            break;
                        }
                    case 36:
                        {
                            IEnumerable<string> strings = str1.Select((i, index) => i + index.ToString());
                            PrintInLabelBox(strings);
                            richTextBox2.Text = "Select((i, index) => i + index.ToString())";
                            break;
                        }
                    case 37:
                        {
                            IEnumerable<int> ints = ConvertToInt(str1);
                            IEnumerable<string> strings = ints.Where(i => i % 3 != 0).Select(i => i % 3 == 1 ? i * i : i).Select(i => i.ToString());
                            PrintInLabelBox(strings);
                            richTextBox2.Text = "Where(i => i % 3 != 0).Select(i => i % 3 == 1 ? i * i : i).Select(i => i.ToString())";
                            break;
                        }
                    case 38:
                        {
                            IEnumerable<char> chars = str1.SelectMany(i => i.ToArray().Where(i1 => Char.IsNumber(i1)));
                            PrintChars(chars);
                            richTextBox2.Text = "SelectMany(i => i.ToArray().Where(i1 => Char.IsNumber(i1)))";
                            break;
                        }
                    case 39:
                        {
                            if (textBox2.Text == String.Empty) return;
                            int digit = Convert.ToInt32(textBox2.Text);
                            IEnumerable<char> chars = str1.Where(i => i.Length >= digit).SelectMany(i => i.ToArray()).Reverse();
                            PrintChars(chars);
                            richTextBox2.Text = "Where(i => i.Length >= digit).SelectMany(i => i.ToArray()).Reverse()";
                            break;
                        }
                    case 40:
                        {
                            if (textBox2.Text == String.Empty) return;
                            int digit = Convert.ToInt32(textBox2.Text);
                            IEnumerable<string> strings = str1.SelectMany(i => i.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries)).Where(i => i.Length == digit);
                            PrintInLabelBox(strings);
                            richTextBox2.Text = "SelectMany(i => i.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries)).Where(i => i.Length == digit)";
                            break;
                        }
                    case 41:
                        {
                            IEnumerable<char> chars = str1.SelectMany((i, index) => (index+1) % 2 == 0 ? i.ToArray().Where(i1 => Char.IsLower(i1)) : i.ToArray().Where(i2 => Char.IsUpper(i2)));
                            PrintChars(chars);
                            richTextBox2.Text = "SelectMany((i, index) => (index+1) % 2 == 0 ? i.ToArray().Where(i1 => Char.IsLower(i1)) : i.ToArray().Where(i2 => Char.IsUpper(i2)))";
                            break;
                        }
                    case 42:
                        {
                            if (textBox2.Text == String.Empty) return;
                            int digit = Convert.ToInt32(textBox2.Text);
                            IEnumerable<char> chars = str1.SelectMany((i, index) => (index + 1) <= digit ? i.ToArray().Where((i1,index1) => (index1+1) % 2 != 0) : i.ToArray().Where((i2,index2) => (index2+1) % 2 == 0)).Reverse();
                            PrintChars(chars);
                            richTextBox2.Text = "SelectMany((i, index) => (index + 1) <= digit ? i.ToArray().Where((i1,index1) => index1+1 % 2 != 0) : i.ToArray().Where((i2,index2) => index2+1 % 2 == 0)).Reverse()";
                            break;
                        }
                    case 43:
                        {
                            if (textBox2.Text == String.Empty) return;
                            if (textBox3.Text == String.Empty) return;
                            if (textBox4.Text == String.Empty) return;
                            int digit1 = Convert.ToInt32(textBox4.Text);
                            int digit2 = Convert.ToInt32(textBox3.Text);
                            string[] str2 = textBox2.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                            IEnumerable<int> ints1 = ConvertToInt(str1);
                            IEnumerable<int> ints2 = ConvertToInt(str2);
                            IEnumerable<string> strings = ints1.Where(i => i > digit1).Concat(ints2.Where(i => i < digit2)).Select(i => i.ToString());
                            PrintInLabelBox(strings);
                            richTextBox2.Text = "ints1.Where(i => i > digit1).Concat(ints2.Where(i => i < digit2)).Select(i => i.ToString())";
                            break;
                        }
                    case 44:
                        {
                            if (textBox2.Text == String.Empty) return;
                            if (textBox3.Text == String.Empty) return;
                            if (textBox4.Text == String.Empty) return;
                            int digit1 = Convert.ToInt32(textBox4.Text);
                            int digit2 = Convert.ToInt32(textBox3.Text);
                            string[] str2 = textBox2.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                            IEnumerable<string> strings = str1.Where(i => i.Length == digit1).Concat(str2.Where(i => i.Length == digit2)).OrderByDescending(i => i);
                            PrintInLabelBox(strings);
                            richTextBox2.Text = ".Where(i => i.Length == digit1).Concat(str2.Where(i => i.Length == digit2)).OrderByDescending(i => i)";
                            break;
                        }
                    case 45:
                        {
                            if (textBox2.Text == String.Empty) return;
                            string[] str2 = textBox2.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                            IEnumerable<string> strings = str1.Join(str2, o => o[o.Length - 1], i => i[i.Length - 1], (o, i) => o + "-" + i);
                            PrintInLabelBox(strings);
                            richTextBox2.Text = " str1.Join(str2, o => o[o.Length - 1], i => i[i.Length - 1], (o, i) => o + \" - \" + i)";
                            break;
                        }
                    case 46:
                        {
                            if (textBox2.Text == String.Empty) return;
                            string[] str2 = textBox2.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                            IEnumerable<string> strings = str1.Join(str2, o => o[o.Length - 1], i => i[0], (o, i) => o + ":" + i);
                            PrintInLabelBox(strings);
                            richTextBox2.Text = " str1.Join(str2, o => o[o.Length - 1], i => i[0], (o, i) => o + \" : \" + i)";
                            break;
                        }
                    case 47:
                        {
                            if (textBox2.Text == String.Empty) return;
                            string[] str2 = textBox2.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                            IEnumerable<string> strings = str1.Join(str2, o => o.Length, i => i.Length, (o, i) => o + ":" + i);
                            PrintInLabelBox(strings);
                            richTextBox2.Text = " str1.Join(str2, o => o.Length], i => i.Length, (o, i) => o + \" : \" + i)";
                            break;

                        }
                    case 48:
                        {
                            if (textBox2.Text == String.Empty) return;
                            if (textBox4.Text == String.Empty) return;
                            string[] str2 = textBox2.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                            string[] str3 = textBox4.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                            IEnumerable<string> strings = str1.Join(str2, o => o[0], i => i[0], (o, i) => o + "=" + i).Join(str3, o=> o[0], i =>i[0], (o,i) => o+"="+i);
                            PrintInLabelBox(strings);
                            richTextBox2.Text = "str1.Join(str2, o => o[0], i => i[0], (o, i) => o + \" = \" + i).Join(str3, o=> o[0], i =>i[0], (o,i) => o+\" = \"+i)";
                            break;
                        }
                    case 49:
                        {
                            if (textBox2.Text == String.Empty) return;
                            string[] str2 = textBox2.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                            IEnumerable<string> strings = str1.GroupJoin(str2, i => i[0], o=>o[0], (i,oe) => i + ":" + oe.Where(o=> o[0] == i[0]).Count());
                            PrintInLabelBox(strings);
                            richTextBox2.Text = "str1.GroupJoin(str2, i => i[0], o=>o[0], (i,oe) => i + \":\" + oe.Where(o=> o[0] == i[0]).Count())";
                            break;
                        }
                    case 50:
                        {
                            if (textBox2.Text == String.Empty) return;
                            string[] str2 = textBox2.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                            IEnumerable<string> strings = str1.GroupJoin(str2, i => i[i.Length-1], o => o[o.Length-1], (i, oe) => oe.Where(o => o[o.Length-1] == i[i.Length-1]).Select(i2 => Convert.ToInt32(i2)).Sum().ToString() + ":" + i);
                            PrintInLabelBox(strings);
                            richTextBox2.Text = "str1.GroupJoin(str2, i => i[i.Length-1], o => o[o.Length-1], (i, oe) => oe.Where(o => o[o.Length-1] == i[i.Length-1]).Select(i2 => Convert.ToInt32(i2)).Sum().ToString() + \":\" + i)";
                            break;
                        }
                    case 51:
                        {
                            if (textBox2.Text == String.Empty) return;
                            string[] str2 = textBox2.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                            IEnumerable<string> strings = str1.Join(str2, i => Char.IsDigit(i[i.Length-1]), o => Char.IsDigit(o[o.Length - 1]), (i, o) => i +"=" + o);
                            PrintInLabelBox(strings);
                            richTextBox2.Text = "str1.Join(str2, i => Char.IsDigit(i[i.Length-1]), o => Char.IsDigit(o[o.Length - 1]), (i, o) => i +\" = \" + o)";
                            break;
                        }
                    case 52:
                        {
                            if (textBox2.Text == String.Empty) return;
                            string[] str2 = textBox2.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                            IEnumerable<int> ints1 = ConvertToInt(str1);
                            IEnumerable<int> ints2 = ConvertToInt(str2);
                            IEnumerable<string> strings = ints1.SelectMany(i => ints2.Select(i1 => i + i1)).Distinct().OrderBy(i => i).Select(i => i.ToString());
                            PrintInLabelBox(strings);
                            richTextBox2.Text = "ints1.SelectMany(i => ints2.Select(i1 => i + i1)).Distinct().OrderBy(i => i).Select(i => i.ToString())";
                            break;
                        }
                    case 53:
                        {
                            if (textBox2.Text == String.Empty) return;
                            string[] str2 = textBox2.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                            IEnumerable<string> strings = str1.GroupJoin(str2, i => i[0], o => o[0], (i, oe) => oe.DefaultIfEmpty("").Select((o) => i+ "." + o)).SelectMany(e1=>e1);
                            PrintInLabelBox(strings);
                            richTextBox2.Text = " str1.GroupJoin(str2, i => i[0], o => o[0], (i, oe) => oe.DefaultIfEmpty(\"\").Select((o) => i+ \".\" + o)).SelectMany(e1=>e1)";
                            break;
                        }
                    case 54:
                        {
                            if (textBox2.Text == String.Empty) return;
                            string[] str2 = textBox2.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                            IEnumerable<string> strings = str1.GroupJoin(str2, i => i[i.Length-1], o => o[o.Length-1], (i, oe) => oe.Select(o1 => Convert.ToInt32(o1)).DefaultIfEmpty(0).Select((o) => i + ":" + o)).SelectMany(e1 => e1);
                            PrintInLabelBox(strings);
                            richTextBox2.Text = "  str1.GroupJoin(str2, i => i[i.Length-1], o => o[o.Length-1], (i, oe) => oe.Select(o1 => Convert.ToInt32(o1)).DefaultIfEmpty(0).Select((o) => i + \":\" + o)).SelectMany(e1 => e1)";
                            break;
                        }
                    case 55:
                        {
                            IEnumerable<string> strings = str1.GroupBy(i => i[i.Length - 1], (k, v) => k + ":" + v.Select(o => Convert.ToInt32(o)).Sum().ToString());
                            PrintInLabelBox(strings);
                            richTextBox2.Text = " str1.GroupBy(i => i[i.Length - 1], (k, v) => k + \":\" + v.Select(o => Convert.ToInt32(o)).Sum().ToString())";
                            break;
                        }
                    case 56:
                        {
                            IEnumerable<string> strings = str1.GroupBy(i => i[i.Length - 1], (k, v) => k + ":" + v.Select(o => Convert.ToInt32(o)).Max().ToString());
                            PrintInLabelBox(strings);
                            richTextBox2.Text = " str1.GroupBy(i => i[i.Length - 1], (k, v) => k + \":\" + v.Select(o => Convert.ToInt32(o)).Max().ToString())";
                            break;
                        }
                    case 57:
                        {
                            IEnumerable<string> strings = str1.GroupBy(i => i.Length, (k, v) => k + ":" + v.First()).OrderBy(k=>k);
                            PrintInLabelBox(strings);
                            richTextBox2.Text = " str1.GroupBy(i => i.Length, (k, v) => k + \":\" + v.First()).OrderBy(k=>k)";
                            break;
                        }
                    case 58:
                        {
                            IEnumerable<string> strings = str1.GroupBy(i => i.Length, (k, v) => k + ":" + v.OrderBy(v1=>v1).First()).OrderByDescending(k => k);
                            PrintInLabelBox(strings);
                            richTextBox2.Text = " str1.GroupBy(i => i.Length, (k, v) => k + \":\" + v.OrderBy(v1=>v1).First()).OrderByDescending(k => k)";
                            break;
                        }
                    case 59:
                        {
                            IEnumerable<string> strings = str1.GroupBy(i => i[0], (k, v) => v.Sum(o=>o.Length)+"-"+k).OrderByDescending(s => s.Split(new char[] {'-'})[0]).ThenBy(s1 => s1.Split(new char[] {'-'})[1]);
                            PrintInLabelBox(strings);
                            richTextBox2.Text = " str1.GroupBy(i => i[0], (k, v) => v.Sum(o=>o.Length)+\" - \"+k).OrderByDescending(s => s.Split(new char[] {\'-\'})[0]).ThenBy(s1 => s1.Split(new char[] {\'-\'})[1])";
                            break;
                        }
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        public IEnumerable<int> ConvertToInt(IEnumerable<string> str)
        {
            return str.Select(i => Convert.ToInt32(i));
        }

        public void PrintInLabelBox(IEnumerable<string> strings)
        {
            richTextBox3.Text = String.Empty;
            foreach (var v in strings)
            {
                richTextBox3.Text += v + " ";
            }
        }

        public void PrintChars(IEnumerable<char> chars)
        {
            richTextBox3.Text = String.Empty;
            foreach (var v in chars)
            {
                richTextBox3.Text += v + " ";
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }

    public class AlmostDistinct : IEqualityComparer<int>
    {
        private int count = 0;
        public bool Equals(int x, int y)
        {
            if (x == y && count == 0)
            {
                count++;
                return false;
             }
            if (x == y && count > 0) return true;
            return false;
        }

        public int GetHashCode(int obj)
        {
            return obj.GetHashCode();
        }
    }
}
