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
            DataSet carWorkshop = new DataSet("CarWorkshop");

            DataTable workTypesTable = new DataTable("WorkTypes");
            DataColumn workTypeID = workTypesTable.Columns.Add("WorkTypeID", typeof(int));
            workTypeID.Unique = true;
            workTypeID.AllowDBNull = false;
            workTypeID.AutoIncrement = true;
            workTypeID.AutoIncrementSeed = 1;
            workTypeID.AutoIncrementStep = 1;
            workTypesTable.Columns.Add("WorkType", typeof(string));
            workTypesTable.PrimaryKey = new DataColumn[] { workTypeID };
            carWorkshop.Tables.Add(workTypesTable);

            DataTable carModelsTable = new DataTable("CarModels");
            DataColumn carModelID = carModelsTable.Columns.Add("CarModelID", typeof(int));
            carModelID.Unique = true;
            carModelID.AllowDBNull = false;
            carModelID.AutoIncrement = true;
            carModelID.AutoIncrementSeed = 1;
            carModelID.AutoIncrementStep = 1;
            carModelsTable.Columns.Add("CarModel", typeof(string));
            carModelsTable.PrimaryKey = new DataColumn[] { carModelID };
            carWorkshop.Tables.Add(carModelsTable);

            DataTable carOwnersTable = new DataTable("CarOwners");
            DataColumn carOwnerID = carOwnersTable.Columns.Add("CarOwnerID", typeof(int));
            carOwnerID.Unique = true;
            carOwnerID.AllowDBNull = false;
            carOwnerID.AutoIncrement = true;
            carOwnerID.AutoIncrementSeed = 1;
            carOwnerID.AutoIncrementStep = 1;
            carOwnersTable.Columns.Add("CarOwnerName", typeof(string));
            carOwnersTable.Columns.Add("PassportSerial", typeof(string));
            carOwnersTable.Columns.Add("PassportNumber", typeof(string));
            carOwnersTable.Columns.Add("PassportIssuedBy", typeof(string));
            carOwnersTable.Columns.Add("PassportIssueDate", typeof(DateTime));
            carOwnersTable.PrimaryKey = new DataColumn[] { carOwnerID };
            carWorkshop.Tables.Add(carOwnersTable);

            DataTable carsTable = new DataTable("Cars");
            DataColumn carID = carsTable.Columns.Add("CarID", typeof(int));
            carID.Unique = true;
            carID.AllowDBNull = false;
            carID.AutoIncrement = true;
            carID.AutoIncrementSeed = 1;
            carID.AutoIncrementStep = 1;
            carsTable.Columns.Add("CarModelID", typeof(int));
            carsTable.Columns.Add("CarOwnerID", typeof(int));
            carsTable.Columns.Add("LicensePlate", typeof(string));
            carsTable.PrimaryKey = new DataColumn[] { carID };
            carWorkshop.Tables.Add(carsTable);

            DataTable mastersTable = new DataTable("Masters");
            DataColumn masterID = mastersTable.Columns.Add("MasterID", typeof(int));
            masterID.Unique = true;
            masterID.AllowDBNull = false;
            masterID.AutoIncrement = true;
            masterID.AutoIncrementSeed = 1;
            masterID.AutoIncrementStep = 1;
            mastersTable.Columns.Add("MasterName", typeof(string));
            mastersTable.Columns.Add("PassportSerial", typeof(string));
            mastersTable.Columns.Add("PassportNumber", typeof(string));
            mastersTable.Columns.Add("PassportIssuedBy", typeof(string));
            mastersTable.Columns.Add("DateOfBirth", typeof(DateTime));
            mastersTable.PrimaryKey = new DataColumn[] { masterID };
            carWorkshop.Tables.Add(mastersTable);

            DataTable worksTable = new DataTable("Works");
            DataColumn workID = worksTable.Columns.Add("WorkID", typeof(int));
            workID.Unique = true;
            workID.AllowDBNull = false;
            workID.AutoIncrement = true;
            workID.AutoIncrementSeed = 1;
            workID.AutoIncrementStep = 1;
            worksTable.Columns.Add("CarID", typeof(int));
            worksTable.Columns.Add("WorkTypeID", typeof(int));
            worksTable.Columns.Add("WorkStartDate", typeof(DateTime));
            worksTable.Columns.Add("WorkMasterID", typeof(int));
            worksTable.Columns.Add("WorkEndDate", typeof(DateTime));
            worksTable.Columns.Add("WorkDescription", typeof(string));
            worksTable.PrimaryKey = new DataColumn[] { workID };
            carWorkshop.Tables.Add(worksTable);

            carWorkshop.Relations.Add("Cars_CarModels", carModelsTable.Columns["CarModelID"], carsTable.Columns["CarModelID"]);
            carWorkshop.Relations.Add("Cars_CarOwners", carOwnersTable.Columns["CarOwnerID"], carsTable.Columns["CarOwnerID"]);
            carWorkshop.Relations.Add("Works_Cars", carsTable.Columns["CarID"], worksTable.Columns["CarID"]);
            carWorkshop.Relations.Add("Works_WorkTypes", workTypesTable.Columns["WorkTypeID"], worksTable.Columns["WorkTypeID"]);
            carWorkshop.Relations.Add("Works_Masters", mastersTable.Columns["MasterID"], worksTable.Columns["WorkMasterID"]);
        }
    }
}
