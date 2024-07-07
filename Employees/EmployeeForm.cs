using Employees.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employees
{
    public partial class EmployeeForm : Form
    {
        private Employee _dudu;

        public EmployeeForm()
        {
            InitializeComponent();
            _dudu = new Employee(
                "2",
                "123123434",
                "Dudu",
                "Azulay",
                Gender.MALE,
                StatusFamily.MARRIED,
                new Address(18, "zonenfield", "Bney brak"),
                DateTime.Now
            );
        }
    }
}
