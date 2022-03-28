using ConsoleApp23.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23.MyPresenter
{
    public class MyAutPresenter
    {
        private IAutorization _bl;
        private IMyView _view;

        public MyAutPresenter(IAutorization bl, IMyView view)
        {
            _bl = bl;
            _view = view;
            _view.EnterPassword += _view_EnterPassword;
            _view.Start();
        }

        private void _view_EnterPassword(object sender, EventArgs e)
        {
            try
            {
               var flag =  _bl.AuthorizationPassword(_view.Password);
               string contetn = MapingAuthorizationPassword(flag);
                _view.Print(contetn);
            }
            catch (Exception ex)
            {
                _view.Print(ex.Message);
            }
        }

        private string MapingAuthorizationPassword(bool flag)
        {
            if (flag)
                return "Успешный вход";
            else
                return "В ходе отказано";
        }
    }
}
