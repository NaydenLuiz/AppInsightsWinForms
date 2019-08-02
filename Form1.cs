using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppInsights
{
    
    public partial class Form1 : Form
    {
        private Microsoft.ApplicationInsights.TelemetryClient _telemetryClient = new Microsoft.ApplicationInsights.TelemetryClient();
        public Form1()
        {
            InitializeComponent();
        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            _telemetryClient.TrackPageView(this.Name);
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            _telemetryClient.Context.User.Id = Environment.UserName;
            _telemetryClient.Context.Device.OperatingSystem = Environment.OSVersion.ToString();
        }
        private void btn_action1_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                MessageBox.Show(button.Text);
                _telemetryClient.TrackEvent(button.Text);
            }
            var form2 = new Form2();
            form2.ShowDialog();
        }
      

        private void btn_exception_Click(object sender, EventArgs e)
        {
            try
            {
                throw new Exception("Description of unhandled exception");
            }
            catch (Exception ex)
            {
                Microsoft.ApplicationInsights.DataContracts.ExceptionTelemetry telemetry = new Microsoft.ApplicationInsights.DataContracts.ExceptionTelemetry();
                telemetry.Exception = ex;
                telemetry.Message = "Error Exception:" + ex.Message;
                _telemetryClient.TrackException(telemetry);
            }


        }

        private void btn_action2_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                MessageBox.Show(button.Text);
                _telemetryClient.TrackEvent(button.Text);
            }
        }

        private void btn_action3_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                MessageBox.Show(button.Text);
                _telemetryClient.TrackEvent(button.Text);
            }
        }

        private void btn_action4_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                MessageBox.Show(button.Text);
                _telemetryClient.TrackEvent(button.Text);
                
            }
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            _telemetryClient.Flush();
        }
    }
}
