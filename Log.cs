using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ApplicationInsights;
namespace WinFormsAppInsights
{
    public class Log
    {
        public static bool Event(string nameClass,string nameFunction, string message)
        {
            TelemetryClient client = new TelemetryClient();
            client.Context.User.Id = Environment.UserName;
            client.Context.Device.OperatingSystem = Environment.OSVersion.ToString();
            client.TrackEvent("Class: " + nameClass + Environment.NewLine + " Function: " + nameFunction + Environment.NewLine + "Message: " + message);
            return true;
        }

        public static bool Event(string message)
        {
            TelemetryClient client = new TelemetryClient();
            client.Context.User.Id = Environment.UserName;
            client.Context.Device.OperatingSystem = Environment.OSVersion.ToString();
            client.TrackEvent("Message: " + message);
            return true;
        }
        public static bool Exception(Exception ex)
        {
            TelemetryClient client = new TelemetryClient();
            client.Context.User.Id = Environment.UserName;
            client.Context.Device.OperatingSystem = Environment.OSVersion.ToString();
            client.TrackException(ex);
            return true;
        }
        public static bool View(string nameView)
        {
            TelemetryClient client = new TelemetryClient();
            client.Context.User.Id = Environment.UserName;
            client.Context.Device.OperatingSystem = Environment.OSVersion.ToString();
            client.TrackPageView(nameView + "--" + DateTime.Now.ToLongDateString());
            return true;
        }
       
        public static bool Trace(string Trace)
        {
            TelemetryClient client = new TelemetryClient();
            client.Context.User.Id = Environment.UserName;
            client.Context.Device.OperatingSystem = Environment.OSVersion.ToString();
            client.TrackTrace(Trace);
            return true;
        }


        public static bool Trace(string nameClass,string nameFunction,string Trace)
        {
            TelemetryClient client = new TelemetryClient();
            client.Context.User.Id = Environment.UserName;
            client.Context.Device.OperatingSystem = Environment.OSVersion.ToString();
            client.TrackTrace("Class: " + nameClass + Environment.NewLine + "Function: " + nameFunction + Environment.NewLine + "Trace: "+ Trace);
            return true;
        }
        public static bool Request(string name, DateTimeOffset startTime,TimeSpan duration,string responseCode,bool sucess)
        {
            TelemetryClient client = new TelemetryClient();
            client.Context.User.Id = Environment.UserName;
            client.Context.Device.OperatingSystem = Environment.OSVersion.ToString();
            client.TrackRequest(name,startTime,duration,responseCode,sucess);
            return true;
        }
    }
}
