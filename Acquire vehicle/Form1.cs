namespace Acquire_vehicle
{
    public partial class Form1 : Form
    {
        Car car1 = new Car();
        Motorcycle moto1 = new Motorcycle();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStartCar_Click(object sender, EventArgs e)
        {
            if (TypeVehicle.Text == "Car")
            {
                
                car1.Brand = txtbBrand.Text;
                car1.Model = txtbModel.Text;
                car1.Class_Vehicle = cbClass.Text;
                MessageBox.Show(car1.StartVehicle() + "\n" + car1.EstimateCost());
            }
            else if (TypeVehicle.Text == "Motorcycle")
            {
               
                moto1.Brand = txtbBrand.Text;
                moto1.Model = txtbModel.Text;
                moto1.Class_Vehicle = cbClass.Text;
                MessageBox.Show(moto1.StartVehicle() + "\n" + moto1.EstimateCost());
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtbModel.Text = "";
            txtbBrand.Text = "";
            TypeVehicle.Text = "";
            cbClass.Text = "";
        }

        private void btnDrift_Click(object sender, EventArgs e)
        {
            if (TypeVehicle.Text == "Car")
            {
                MessageBox.Show(car1.Drift());
            }
            else if (TypeVehicle.Text == "Motorcycle")
            {
                MessageBox.Show(moto1.Drift());
            }
           
        }
    }
}
