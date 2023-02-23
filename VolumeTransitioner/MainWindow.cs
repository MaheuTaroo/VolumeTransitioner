

// TODO - Add to GitHub

using VolumeTransitioner.Properties;
using DefaultTimer = System.Timers.Timer;

namespace VolumeTransitioner
{
    public partial class MainWindow : Form
    {
        bool isOnMax = true, isChanging = false;
        readonly DefaultTimer t = new(100);

        public MainWindow()
        {
            InitializeComponent();
            Icon = Resources.icon;
            nupMax.Value = (decimal)AudioManager.GetMasterVolume();
            nupMax.Minimum = 0;
            nupMax.Enabled = false;
            t.Elapsed += delegate
            {
                if (AudioManager.GetMasterVolume() != (float)(isOnMax ? nupMax : nupMin).Value && !isChanging)
                    AudioManager.SetMasterVolume((float)(isOnMax ? nupMax : nupMin).Value);
            };
            t.Start();
        }

        private void MaxVolChanged(object sender, EventArgs e)
        {
            _ = int.TryParse(((UpDownBase)sender).Text, out int maxVal);
            if (maxVal == (int)AudioManager.GetMasterVolume() && nupMax.Value < maxVal)
            {
                nupMax.Value = maxVal;
                return;
            }
            if (nupMin.Value > nupMax.Value) nupMin.Value = nupMax.Value;
        }

        private void MinVolChanged(object sender, EventArgs e)
        {
            _ = int.TryParse(((UpDownBase)sender).Text, out int minVal);
            if (minVal == AudioManager.GetMasterVolume() && nupMin.Value > minVal)
            {
                nupMin.Value = minVal;
                return;
            }
            if (nupMin.Value > nupMax.Value) nupMax.Value = nupMin.Value;
        }
        
        private void Toggle(object sender, EventArgs e)
        {
            nupMax.Enabled = nupMin.Enabled = btnToggle.Enabled = false;
            lblToggle.Text = "Toggling...";
            Update();
            float val = (float)(isOnMax ? nupMin.Value : nupMax.Value);
            isChanging = true;
            while (isOnMax ? AudioManager.GetMasterVolume() > val : AudioManager.GetMasterVolume() < val)
            {
                AudioManager.StepMasterVolume(isOnMax ? -1 : 1);
                Thread.Sleep(50);
            }
            isOnMax = !isOnMax;
            if (AudioManager.GetMasterVolume() != (float)(isOnMax ? nupMax : nupMin).Value) AudioManager.SetMasterVolume((float)(isOnMax ? nupMax : nupMin).Value);
            isChanging = false;
            lblToggle.Text = "Toggled to " + (isOnMax ? "max" : "min") + "imum value";
            btnToggle.BackgroundImage = isOnMax ? Resources.ToggleUp : Resources.ToggleDown;
            (isOnMax ? nupMin : nupMax).Enabled = btnToggle.Enabled = true;
        }
    }
}