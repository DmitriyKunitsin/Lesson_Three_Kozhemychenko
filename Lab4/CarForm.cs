using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming
{
    public partial class CarForm : Form
    {
        public CarForm()
        {
            InitializeComponent();
        }

        private void CarForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                try
                {
                    if (textBoxModelName.Text.Trim() == "")
                    {
                        textBoxModelName.Focus();
                        throw new Exception("Не введено название модели!");
                    }
                    if (textBoxManufacturerName.Text.Trim() == "")
                    {
                        textBoxManufacturerName.Focus();
                        throw new Exception("Не введено наименование производителя!");
                    }
                    try
                    {
                        if (textBoxFuelConsumption.Text.Trim() != "")
                        {
                            double quantity = Convert.ToDouble(textBoxFuelConsumption.Text);
                            if (quantity < 2.0 || quantity > 80.0)
                            {
                                textBoxFuelConsumption.Focus();
                                throw new Exception("Некорректный расход топлива [2,0 - 80,0]!");
                            }
                        }
                        else
                        {
                            textBoxFuelConsumption.Focus();
                            throw new Exception("Не указан расход топлива [2,0 - 80,0]!");
                        }

                    }
                    catch (FormatException)
                    {
                        textBoxFuelConsumption.Focus();
                        throw new FormatException("Некорректный расход топлива (расход может быть задан только вещественным числом в диапазоне [2,0 - 80,0]");
                    }
                    try
                    {
                        if (textBoxWeight.Text.Trim() != "")
                        {
                            int income = Convert.ToInt32(textBoxWeight.Text);
                            if (income < 100 || income > 5000)
                            {
                                textBoxWeight.Focus();
                                throw new Exception("Некорректное значение массы автомобиля [100 - 5000]!");
                            }
                        }
                        else
                        {
                            textBoxWeight.Focus();
                            throw new Exception("Не введена масса автомобиля [100 - 5000]!");
                        }
                    }
                    catch (FormatException)
                    {
                        textBoxWeight.Focus();
                        throw new FormatException("Некорректная масса (масса может быть задана только целым числом в диапазоне [100 - 5000]");
                    }
                    
                }
                catch (FormatException ex)
                {
                    e.Cancel = true;
                    MessageBox.Show(ex.Message + "\nПовторите ввод или нажмите на кнопку \"Отмена\"", "Ошибка!");
                }
                catch (Exception ex)
                {
                    e.Cancel = true;
                    MessageBox.Show(ex.Message + "\nПовторите ввод или нажмите на кнопку \"Отмена\"", "Ошибка!");
                }
            }
        }
    }
}