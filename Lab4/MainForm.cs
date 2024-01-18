namespace Programming
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            CarForm carForm = new CarForm();
            carForm.Text = "Добавление новой записи...";

            if (carForm.ShowDialog() == DialogResult.OK)
            {
                Car car = new Car();
                car.ModelName = carForm.textBoxModelName.Text;
                car.ManufacturerName = carForm.textBoxManufacturerName.Text;
                car.FuelConsumption = Convert.ToDouble(carForm.textBoxFuelConsumption.Text);
                car.Weight = Convert.ToInt32(carForm.textBoxWeight.Text);
                listBoxCars.Items.Add(car);

                buttonSave.Enabled = toolStripButtonSave.Enabled = сохранитьToolStripMenuItem.Enabled = true;
                buttonProceed.Enabled = toolStripButtonProceed.Enabled = вывестиToolStripMenuItem.Enabled = true;
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (listBoxCars.SelectedIndex != -1)
            {
                listBoxCars.Items.Remove(listBoxCars.SelectedItem);

                if (listBoxCars.Items.Count == 0)
                {
                    buttonSave.Enabled = toolStripButtonSave.Enabled = сохранитьToolStripMenuItem.Enabled = false;
                    buttonProceed.Enabled = toolStripButtonProceed.Enabled = вывестиToolStripMenuItem.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Не выбран элемент для удаления!", "Предупреждение");
            }

        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            if (listBoxCars.SelectedIndex != -1)
            {
                CarForm carForm = new CarForm();
                carForm.Text = "Изменение существующей записи...";

                Car car = listBoxCars.Items[listBoxCars.SelectedIndex] as Car;
                carForm.textBoxModelName.Text = car.ModelName;
                carForm.textBoxManufacturerName.Text = car.ManufacturerName;
                carForm.textBoxFuelConsumption.Text = car.FuelConsumption.ToString();
                carForm.textBoxWeight.Text = car.Weight.ToString();

                if (carForm.ShowDialog() == DialogResult.OK)
                {
                    car.ModelName = carForm.textBoxModelName.Text;
                    car.ManufacturerName = carForm.textBoxManufacturerName.Text;
                    car.FuelConsumption = Convert.ToDouble(carForm.textBoxFuelConsumption.Text);
                    car.Weight = Convert.ToInt32(carForm.textBoxWeight.Text);
                    listBoxCars.Items[listBoxCars.SelectedIndex] = car;
                }
            }
            else
            {
                MessageBox.Show("Не выбран элемент для редактирования!", "Предупреждение");
            }


        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Бинарные файлы (*.dat)|*.dat| (*.*)|*.*";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    using (BinaryReader br = new BinaryReader(File.Open(filePath, FileMode.Open)))
                    {
                        listBoxCars.Items.Clear();
                        while (br.PeekChar() != -1)
                        {
                            Car car = new Car();
                            car.ModelName = br.ReadString();
                            car.ManufacturerName = br.ReadString();
                            car.FuelConsumption = br.ReadDouble();
                            car.Weight = br.ReadInt32();
                            listBoxCars.Items.Add(car);
                        }
                    }
                    if (listBoxCars.Items.Count > 0)
                    {
                        buttonSave.Enabled = toolStripButtonSave.Enabled = сохранитьToolStripMenuItem.Enabled = true;
                        buttonProceed.Enabled = toolStripButtonProceed.Enabled = вывестиToolStripMenuItem.Enabled = true;
                    }
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = "c:\\";
                saveFileDialog.Filter = "Бинарные файлы (*.dat)|*.dat| (*.*)|*.*";
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    using (BinaryWriter bw = new BinaryWriter(File.Open(filePath, FileMode.Create)))
                    {
                        foreach (Car car in listBoxCars.Items)
                        {
                            bw.Write(car.ModelName);
                            bw.Write(car.ManufacturerName);
                            bw.Write(car.FuelConsumption);
                            bw.Write(car.Weight);
                        }
                    }
                }
            }
        }

        private void buttonProceed_Click(object sender, EventArgs e)
        {
            if (listBoxCars.Items.Count > 0)
            {
                Car mostFuelEfficientCar = listBoxCars.Items[0] as Car;
                double efficientRatio = mostFuelEfficientCar.FuelConsumption / mostFuelEfficientCar.Weight;
                for (int i = 1; i < listBoxCars.Items.Count; i++)
                {
                    Car car = listBoxCars.Items[i] as Car;
                    // Расход деленный на массу 
                    double fuelConsumptionRatio = car.FuelConsumption / car.Weight;
                    if (fuelConsumptionRatio < efficientRatio)
                    {
                        mostFuelEfficientCar = car;
                        efficientRatio = fuelConsumptionRatio;
                    }
                }
                mostEfficientCarTextBox.Text = $"{mostFuelEfficientCar.ModelName} {mostFuelEfficientCar.ManufacturerName} {efficientRatio}";

            }
            else
            {
                MessageBox.Show("Список пуст!", "Ошибка");
            }
        }

        #region toolStripMenuButton's methods
        private void toolStripButtonAdd_Click(object sender, EventArgs e) => buttonAdd_Click(sender, e);
        private void toolStripButtonModify_Click(object sender, EventArgs e) => buttonModify_Click(sender, e);
        private void toolStripButtonRemove_Click(object sender, EventArgs e) => buttonRemove_Click(sender, e);
        private void toolStripButtonLoad_Click(object sender, EventArgs e) => buttonLoad_Click(sender, e);
        private void toolStripButtonSave_Click(object sender, EventArgs e) => buttonSave_Click(sender, e);
        private void toolStripButtonProceed_Click(object sender, EventArgs e) => buttonProceed_Click(sender, e);
        #endregion

        #region toolStripButton's methods
        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e) => buttonAdd_Click(sender, e);
        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e) => buttonModify_Click(sender, e);
        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e) => buttonRemove_Click(sender, e);
        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e) => buttonLoad_Click(sender, e);
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e) => buttonSave_Click(sender, e);
        private void вывестиToolStripMenuItem_Click(object sender, EventArgs e) => buttonProceed_Click(sender, e);
        #endregion

        private void listBoxCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxCars.SelectedIndex != -1)
            {
                Car car = listBoxCars.Items[listBoxCars.SelectedIndex] as Car;
                toolStripModelName.Text = car.ModelName;
                toolStripManufacturerName.Text = car.ManufacturerName;
                toolStripFuelConsumption.Text = car.FuelConsumption.ToString();
                toolStripWeight.Text = car.Weight.ToString();

                buttonModify.Enabled = toolStripButtonModify.Enabled = изменитьToolStripMenuItem.Enabled = true;
                buttonRemove.Enabled = toolStripButtonRemove.Enabled = удалитьToolStripMenuItem.Enabled = true;
            }
            else
            {
                toolStripModelName.Text = toolStripManufacturerName.Text = toolStripFuelConsumption.Text = toolStripWeight.Text = "";

                buttonModify.Enabled = toolStripButtonModify.Enabled = изменитьToolStripMenuItem.Enabled = false;
                buttonRemove.Enabled = toolStripButtonRemove.Enabled = удалитьToolStripMenuItem.Enabled = false;
            }
        }
    }
}