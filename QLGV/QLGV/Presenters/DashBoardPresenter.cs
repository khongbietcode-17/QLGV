using QLGV.Factories;
using QLGV.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLGV.Presenters
{
    public class DashBoardPresenter
    {
        IDashboard _view;
        IFormFactory _formFactory;
        public DashBoardPresenter(IDashboard view) 
        {
            _view = view;
            _formFactory = new DashBoardChildrenFactory();
            AddActionListener();
        }

        public void AddActionListener()
        {
            foreach(Button button in _view.getMenuControls())
            {
                button.Click += (object o,EventArgs e) => {
                    _view.SetChildren(_formFactory.GetForm(button.Name));
                };
            }
        }
    }
}
