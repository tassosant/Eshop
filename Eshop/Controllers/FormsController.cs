using Eshop.CustomComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eshop.Controllers
{
    public static class FormsController
    {
        private static Dictionary<Type, Form> openForms = new Dictionary<Type, Form>();


        //public static void ShowForm<T>() where T : Form, new()
        //{
        //    Type formType = typeof(T);

        //    //if dictionary does not have instantiated form, then add it and create an instance of the form
        //    if (!openForms.ContainsKey(formType) || openForms[formType].IsDisposed)
        //    {
        //        openForms[formType] = new T();
        //        openForms[formType].FormClosed += (sender, e) => openForms.Remove(formType);
        //    }

        //    openForms[formType].Show();
        //    openForms[formType].BringToFront();
        //}

        public static void ShowForm(Type formType, int userId)
        {


            //if dictionary does not have instantiated form, then add it and create an instance of the form
            if (!openForms.ContainsKey(formType) || openForms[formType].IsDisposed)
            {
                
                Form form = (Form)Activator.CreateInstance(formType, new object[] { userId });
                //Form form = (Form)Activator.CreateInstance(formType);
                HandleUserId(form, formType);
                
                openForms.Add(formType, form);
                //openForms[formType].FormClosed += (sender, e) => openForms.Remove(formType);
                openForms[(formType)].Disposed += (sender, e) => openForms.Remove(formType);

            }


            openForms[formType].Show();
            openForms[formType].BringToFront();

        }

        //using c# reflection
        private static void HandleUserId(Form form, Type type)
        {
            FieldInfo navbar1 = form.GetType().GetField("navbar1",BindingFlags.Instance | BindingFlags.NonPublic);
            Navbar navbar = (Navbar)navbar1.GetValue(form);
            PropertyInfo user = type.GetProperty("UserID");
            navbar.UpdateUserID(type,(int) user.GetValue(form));
        }
    }
}
