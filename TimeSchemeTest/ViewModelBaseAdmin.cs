using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace TimeSchemeTest
{
    public enum ViewCloseCode { Remove, Close } // add to ViewModelBase

    public abstract class ViewModelBaseAdmin
    {
        protected Window view;
        // Every View MUST set a Guid in its constructor.
        protected Guid viewId;
        protected string languageCode;
        protected bool keyboard;
       // private ViewCloseCode viewCloseCode;
        // Set if we want to report any special code for DialogResult.
        protected int dialogResultInfo;

        public ViewModelBaseAdmin(Window aView) // , Guid aViewId
        {
            view = aView;
        }

        public Guid ViewId
        {
            get { return viewId; }
        }

        public int DialogResultInfo
        {
            get { return dialogResultInfo; }
        }

        public string LanguageCode
        {
            get { return languageCode; }
        }

    }
}
