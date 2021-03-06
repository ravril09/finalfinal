using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using CST.Models;


namespace CST
{
    public partial class Login : Form

    {
      
        loginController control = new loginController();
        dbConnection dbConnection = new dbConnection();
        AuditTrailControl audittrail = new AuditTrailControl();
      

        bool isConnected;

        public Login()
        { 
            InitializeComponent();

           

        }

        private void Login_Load(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;
            txtUN.Hide();
            txtUT.Hide();
            label1.Hide();
            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();


            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();

         

            label7.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");

            timer1.Enabled = true;
            isConnected = dbConnection.EstablishConnection();



        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void label7_Click(object sender, EventArgs e)
        {

          
        }

        public void DateTicks_Tick(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e) 


        {

            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();


            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();

          

            label7.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");

            timer1.Enabled = true;

        }



        private void btnLogin_Click(object sender, EventArgs e)

        {
            if (!isConnected)
            {
                label1.Text = "No Connection";
                MessageBox.Show("There is no connection to the database.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                IPConfigFormcs g = new IPConfigFormcs();
                g.ShowDialog();
            }
            else
            {
               string role = control.login(txtUsername.Text.Trim(), txtPassword.Text.Trim());

                if (role == "")
                {
                    MessageBox.Show("Incorrect Username or Password!","Validation",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    audittrail.addAudit(label7.Text.Trim(), "User has been Login");
                    control.setOnline(UserLog.getUserId());
                    int isPaswwordChanged = UserLog.getIsPasswordChanged();
                //    LoginPreferences.CreateLoginPrefFile();
                    if (role == "President")
                    {
                        if (isPaswwordChanged == 0)
                        {
                            Generated frmGen = new Generated(role);
                            frmGen.Show();
                            this.Hide();
                        }
                        else
                        {
                            Admin frm = new Admin();
                            frm.Show();
                            this.Hide();

                        }
                      

                    }

                    else if (role == "Volunteer")
                    {
                        if (isPaswwordChanged == 0)
                        {
                            Generated frmGen = new Generated(role);
                            frmGen.Show();
                            this.Hide();
                        }
                        else
                        {
                            RegistrarForm frm = new RegistrarForm();
                            frm.Show();
                            this.Hide();
                        }

                    }

                   
                }
                

            }
           }
       



        private void txtUsername_TextChanged(object sender, EventArgs e)
        {       // text null symbol only  prompt side 

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                errorProvider1.SetError(txtUsername, "Please enter your Username!");

                btnLogin.Enabled = false;

              
                 
            }


            else
            {
                if (string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    btnLogin.Enabled = false;
                }
                else

                btnLogin.Enabled = true;
                errorProvider1.SetError(txtUsername, null);

                                return;

                            }


        }



        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            // text null symbol only  prompt side 
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                 errorProvider1.SetError(txtPassword, "Please enter your password!");
         
                 btnLogin.Enabled = false;
                                        
                 
                    
                }
            
         
        

            else
            {
                if (string.IsNullOrWhiteSpace(txtUsername.Text))
                {
                    btnLogin.Enabled = false;
                }
                else
               
                btnLogin.Enabled = true;
                errorProvider1.SetError(txtPassword, null);
            

                return;


            }
            





        }

        private void label6_Click(object sender, EventArgs e)
        {





         
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

           if( label1.Text == "No Connection")
            {
                this.Hide();
                IPConfigFormcs g = new IPConfigFormcs();
                   g.ShowDialog();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Login_KeyUp(object sender, KeyEventArgs e)
        {
          
             if (e.KeyCode == Keys.F1)
            {
                /* Admin-S */
                txtUsername.Text = "kbadiana2416";
                txtPassword.PasswordChar = '*';
                txtPassword.Text = "12345678";
            }
           
            else if (e.KeyCode == Keys.F3)
            {
                /* Registrar */
                txtUsername.Text = "mjadlocon6188";
                txtPassword.PasswordChar = '*';
                txtPassword.Text = "12345678";
            }
          

    }

    private void pbMinimized_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
    }



