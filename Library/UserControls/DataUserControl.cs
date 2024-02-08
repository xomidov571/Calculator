using Library.Models;
using Library.Servises;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Desktop.UserControls
{
    public partial class DataUserControl : Form
    {
        private readonly BookService service;

        public DataUserControl(BookService service)
        {
            InitializeComponent();
            this.service = service;
        }
    }
}
