using System;
using System.Data.Entity.Infrastructure;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using OKInvestir.UI;
using OKInvestir.Model;

namespace OKInvestir.ViewModel
{
    public class VMMain
    {
        public UIMainForm UIMainForm { get; set; }

        public VMLogin VMLogin { get; set; }
        public UILogin UILogin { get; set; }

        public VMDashboard VMDashboard { get; set; }
        public UIDashboard UIDashboard { get; set; }

        public VMClient VMClient { get; set; }
        public UIClient UIClient { get; set; }

        public VMProduct VMProduct { get; set; }
        public UIProduct UIProduct { get; set; }

        public VMSimulation VMSimulation { get; set; }
        public UISimulation UISimulation { get; set; }

        public User User { get; set; }
        public Client Client { get; set; }
        public Product Product { get; set; }

        public VMMain()
        {
            UIMainForm = new UIMainForm();
            UIMainForm.VMMain = this;
            switchToLogin(); // App start page
                             //switchToMainPage(null, new Model.User(1));
            UISimulation = new UISimulation();
            VMSimulation = new VMSimulation(this, UISimulation);
        }


        /**
         * Function to logout
         */
         public void logout()
        {
            User = null;
            switchToLogin();
        }


        /**
         * Functions to switch between UserControls
         */
        public void switchToLogin()
        {
            UILogin = new UILogin();
            VMLogin = new VMLogin(this, UILogin);

            //remove whatever control is currently in the Panel
            UIMainForm.getPnUserControl().Controls.Clear();
            //add the other control, the HomePage control instead now
            UIMainForm.getPnUserControl().Controls.Add(UILogin);
        }


        public void switchToDashboard()
        {
            if(User != null)
            {
                if(UIDashboard == null)
                {
                    UIDashboard = new UIDashboard();
                    VMDashboard = new VMDashboard(this, UIDashboard);

                }
                UIMainForm.getPnUserControl().Controls.Clear();
                UIMainForm.getPnUserControl().Controls.Add(UIDashboard);
            } else
            {
                switchToLogin();
            }
        }

        public void switchToClient()
        {
            if (User != null)
            {
                if (UIClient == null)
                {
                    UIClient = new UIClient();
                    VMClient = new VMClient(this, UIClient);

                }
                UIMainForm.getPnUserControl().Controls.Clear();
                UIMainForm.getPnUserControl().Controls.Add(UIClient);
                
            }
            else
            {
                switchToLogin();
            }
        }

        public void switchToProduct()
        {
            if (User != null)
            {
                if (UIProduct == null)
                {
                    UIProduct = new UIProduct();
                    VMProduct = new VMProduct(this, UIProduct);

                }
                UIMainForm.getPnUserControl().Controls.Clear();
                UIMainForm.getPnUserControl().Controls.Add(UIProduct);
            }
            else
            {
                switchToLogin();
            }
        }
        
        public void switchToSubProduct(UISubProduct sub)
        {
            UIMainForm.getPnUserControl().Controls.Clear();
            UIMainForm.getPnUserControl().Controls.Add(sub);
        }

        public void switchToSimulation()
        {
            if (User != null)
            {
               if(Client != null)
                {
                    UIMainForm.getPnUserControl().Controls.Clear();
                    UIMainForm.getPnUserControl().Controls.Add(UISimulation);
                    this.VMSimulation.printBalance();
                    this.VMSimulation.getSimulation();
                }
                else
                {
                    UIMainForm.genMsgBox("You haven't chose a client.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if(UIMainForm.getPnUserControl().Controls.Contains(this.UIClient))
                    {
                        UIMainForm.getBtClient().PerformClick();
                    } else if (UIMainForm.getPnUserControl().Controls.Contains(this.UIDashboard))
                    {
                        UIMainForm.getBtDashboard().PerformClick();
                    }
                    else if (UIMainForm.getPnUserControl().Controls.Contains(this.UIProduct))
                    {
                        UIMainForm.getBtProduct().PerformClick();
                    }
                }
                
            }
            else
            {
                switchToLogin();
            }
        }

       



        /**
         * Functions to handle mysql exception
         */
        public virtual void HandleException(Exception exception, UIMainForm form)
        {
            DbUpdateException dbUpdateEx = exception as DbUpdateException;
            if (dbUpdateEx != null)
            {
                if (dbUpdateEx != null
                        && dbUpdateEx.InnerException != null
                        && dbUpdateEx.InnerException.InnerException != null)
                {
                    MySqlException sqlException = dbUpdateEx.InnerException.InnerException as MySqlException;
                    if (sqlException != null)
                    {
                        DatabaseAccessException(form, dbUpdateEx.Message, sqlException.Message, sqlException.Number);
                    } else
                    {
                        form.genMsgBox("Message = " + dbUpdateEx.Message + "\nInnerException = " + dbUpdateEx.InnerException,
                            "DataBase Access Exception", System.Windows.Forms.MessageBoxButtons.OK, 
                            System.Windows.Forms.MessageBoxIcon.Error);
                    }
                }
                else
                {
                    form.genMsgBox("Message = " + dbUpdateEx.Message,
                            "DataBase Access Exception", System.Windows.Forms.MessageBoxButtons.OK,
                            System.Windows.Forms.MessageBoxIcon.Error);
                }
            }
            else
            {
                form.genMsgBox("Error\n But not DbUpdateException",
                            "DataBase Access Exception", System.Windows.Forms.MessageBoxButtons.OK,
                            System.Windows.Forms.MessageBoxIcon.Error);
            }
        } 

        public void DatabaseAccessException(UIMainForm form, string dbUpdateExMessage, string dbUpdateExInnerException, int sqlExceptionNumber)
        {
            switch (sqlExceptionNumber)
            {
                case 1062:
                    form.genMsgBox("Unique constraint failed.", "DataBase Access Exception",
                        System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    break;

                default:
                    form.genMsgBox("Message = " + dbUpdateExMessage + "\nInnerException = " + dbUpdateExInnerException
                        + "\nsqlExceptionNumber = " + sqlExceptionNumber, "DataBase Access Exception",
                        System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    break;
            }
            
        }
    }
}
