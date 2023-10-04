using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRepairDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet carWorkshop = new DataSet("Car Workshop");

            DataTable workTypes = new DataTable("Work Types");
            DataColumn workTypeID = new DataColumn("ID", typeof(int));
            workTypeID.Unique = true;
            workTypeID.AllowDBNull = false;
            workTypeID.AutoIncrement = true;
            workTypeID.AutoIncrementSeed = 1;
            workTypeID.AutoIncrementStep = 1;
            DataColumn workType = new DataColumn("Type", typeof(string));
            workTypes.Columns.Add(workTypeID);
            workTypes.Columns.Add(workType);


            DataTable carModels = new DataTable("Car Models");
            DataColumn carModelID = new DataColumn("ID", typeof(int));
            carModelID.Unique = true;
            carModelID.AllowDBNull = false;
            carModelID.AutoIncrement = true;
            carModelID.AutoIncrementSeed = 1;
            carModelID.AutoIncrementStep = 1;
            DataColumn carModel = new DataColumn("Model", typeof(string));
            carModels.Columns.Add(carModelID);
            carModels.Columns.Add(carModel);


            DataTable carOwners = new DataTable("Car Owners");
            DataColumn carOwnerID = new DataColumn("ID", typeof(int));
            carOwnerID.Unique = true;
            carOwnerID.AllowDBNull = false;
            carOwnerID.AutoIncrement = true;
            carOwnerID.AutoIncrementSeed = 1;
            carOwnerID.AutoIncrementStep = 1;
            DataColumn carOwnerName = new DataColumn("Name", typeof(string));
            DataColumn carOwnerPassportSerial = new DataColumn("Passport Serial", typeof(string));
            DataColumn carOwnerPassportNumber = new DataColumn("Passport Number", typeof(string));
            DataColumn carOwnerPassportOther = new DataColumn("Passport Other", typeof(string));
            carOwners.Columns.Add(carOwnerID);
            carOwners.Columns.Add(carOwnerName);
            carOwners.Columns.Add(carOwnerPassportSerial);
            carOwners.Columns.Add(carOwnerPassportNumber);
            carOwners.Columns.Add(carOwnerPassportOther);


            DataTable cars = new DataTable("Cars");
            DataColumn carID = new DataColumn("ID", typeof(int));
            carID.Unique = true;
            carID.AllowDBNull = false;
            carID.AutoIncrement = true;
            carID.AutoIncrementSeed = 1;
            carID.AutoIncrementStep = 1;
            DataColumn carLicensePlate = new DataColumn("License Plate", typeof(string));
            cars.Columns.Add(carID);
            cars.Columns.Add(carLicensePlate);


            DataTable masters = new DataTable("Masters");
            DataColumn masterID = new DataColumn("ID", typeof(int));
            masterID.Unique = true;
            masterID.AllowDBNull = false;
            masterID.AutoIncrement = true;
            masterID.AutoIncrementSeed = 1;
            masterID.AutoIncrementStep = 1;
            DataColumn masterName = new DataColumn();
            DataColumn masterPassportSerial = new DataColumn("Passport Serial", typeof(string));
            DataColumn masterPassportNumber = new DataColumn("Passport Number", typeof(string));
            DataColumn masterPassportOther = new DataColumn("Passport Other", typeof(string));
            DataColumn masterDateOfBirth = new DataColumn("Date of Birth", typeof(string));
            masters.Columns.Add(masterID);
            masters.Columns.Add(masterName);
            masters.Columns.Add(masterPassportSerial);
            masters.Columns.Add(masterPassportNumber);
            masters.Columns.Add(masterPassportOther);
            masters.Columns.Add(masterDateOfBirth);
            

            DataTable works = new DataTable("Works");


            carWorkshop.Tables.Add(workTypes);
            carWorkshop.Tables.Add(carModels);
            carWorkshop.Tables.Add(carOwners);
            carWorkshop.Tables.Add(cars);
            carWorkshop.Tables.Add(masters);
            carWorkshop.Tables.Add(works);
        }
    }
}
