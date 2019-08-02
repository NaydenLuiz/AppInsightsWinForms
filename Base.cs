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
    public partial class Base : Form
    {
        private Microsoft.ApplicationInsights.TelemetryClient _telemetryClient = new Microsoft.ApplicationInsights.TelemetryClient();
        public Base()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _telemetryClient.Context.User.Id = Environment.UserName;
            _telemetryClient.Context.Device.OperatingSystem = Environment.OSVersion.ToString();

            foreach (Control control in this.Controls)
            {
                RegistrarAcaoDeTelemetria(control);
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            _telemetryClient.Flush();
        }

        private void RegistrarAcaoDeTelemetria(Control controle)
        {
            if (controle is Button)
                RegistrarAcaoDeTelemetria((Button)controle);
        }

        private void RegistrarAcaoDeTelemetria(Button botao)
        {
            botao.Click += (s, e) => _telemetryClient.TrackEvent(botao.Text);
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            _telemetryClient.TrackPageView(this.Name);
        }

    }
}
