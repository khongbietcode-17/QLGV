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
        Dashboard _view;
        IFactory<Form> _formFactory;
        public DashBoardPresenter(Dashboard view) 
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
                    _view.SetChildren(_formFactory.GetInstance(button.Name));
                };
            }
        }
    }
}
