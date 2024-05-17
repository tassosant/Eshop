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
                
                openForms.Add(formType, form);
                //openForms[formType].FormClosed += (sender, e) => openForms.Remove(formType);
                openForms[(formType)].Disposed += (sender, e) => openForms.Remove(formType);

                HandleUserId(openForms[formType], formType);

            
                openForms[formType].Show();
            }
            else
            {
                HandleUserId(openForms[formType], formType);
                openForms[formType].Invalidate(true);
                openForms[formType].Update();
                openForms[formType].Refresh();
            }
            if(formType == typeof(CartForm)) {
                
                MethodInfo method = openForms[formType].GetType().GetMethod("RunFormPropertiesInitializingFunctions");
                if(method != null)
                {

                    openForms[formType].Invoke(new MethodInvoker(()=> method.Invoke(openForms[formType],null)));
                                        
                }
                openForms[formType].Invalidate(true);
                openForms[formType].Update();
                openForms[formType].Refresh();
            }
            openForms[formType].BringToFront();

        }

        //using c# reflection
        private static void HandleUserId(Form form, Type type)
        {
            FieldInfo navbar1 = form.GetType().GetField("navbar1",BindingFlags.Instance | BindingFlags.NonPublic);
            Navbar navbar = (Navbar)navbar1.GetValue(form);
            PropertyInfo user = type.GetProperty("UserID");
            navbar.UpdateUserID(type,(int) user.GetValue(form));
            navbar.CheckForPermissions();
        }
    }
}
