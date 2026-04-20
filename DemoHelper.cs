using System.Windows.Forms;

namespace MachineProject3_TMS
{
    public static class DemoHelper
    {
        public static bool IsDemoMode { get; set; } = false;

        public static void EnableDemoMode()
        {
            IsDemoMode = true;
            DbConnection.Disconnect();
        }

        public static bool InterceptAction(string featureTitle, string featureDescription)
        {
            if (!IsDemoMode)
            {
                return false;
            }

            MessageBox.Show(
                $"Demo Mode: {featureTitle}\n\n{featureDescription}",
                "Demo Mode",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            return true;
        }

        public static void DisableDemoMode()
        {
            IsDemoMode = false;
        }
    }
}
