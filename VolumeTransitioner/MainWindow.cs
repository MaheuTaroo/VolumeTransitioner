using VolumeTransitioner.Properties;
using VolumeTransitioner.Audio;
using DefaultTimer = System.Timers.Timer;
using System.Reflection;

namespace VolumeTransitioner
{
    public partial class MainWindow : Form
    {
        bool isOnMax = true, isChanging = false;
        readonly DefaultTimer t = new DefaultTimer(100);

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

        public MainWindow(decimal max, decimal min, bool onMax)
        {
            InitializeComponent();
            Icon = Resources.icon;
            nupMax.Value = max;
            nupMin.Value = min;
            isOnMax = onMax;

            (isOnMax ? nupMax : nupMin).Enabled = false;

            if (isOnMax && (int)AudioManager.GetMasterVolume() != nupMax.Value)
                AudioManager.SetMasterVolume((float)nupMax.Value);
            else if (!isOnMax && (int)AudioManager.GetMasterVolume() != nupMin.Value)
                AudioManager.SetMasterVolume((float)nupMin.Value);

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
            nupMax.Enabled = nupMin.Enabled = btnToggle.Enabled = mitSavePreset.Enabled = mitLoadPreset.Enabled = false;
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
            lblToggle.Text = $"Toggled to {(isOnMax ? "max" : "min")}imum value";
            btnToggle.BackgroundImage = isOnMax ? Resources.ToggleUp : Resources.ToggleDown;
            (isOnMax ? nupMin : nupMax).Enabled = btnToggle.Enabled = mitSavePreset.Enabled = mitLoadPreset.Enabled = true;
        }

        private void SavePreset(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog()
            {
                Filter = "Volume Transitioner Preset|*.vtp",
                ShowPinnedPlaces = true,
                CheckWriteAccess = true
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ExtraFunctions.SavePreset(dialog.FileName, (int)nupMax.Value, (int)nupMin.Value, isOnMax);
            }
        }

        private void LoadPreset(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog()
            {
                Filter = "Volume Transitioner Preset|*.vtp",
                ShowPinnedPlaces = true,
                ShowHiddenFiles = true,
                AddToRecent = true,
                DereferenceLinks = true,
                Multiselect = false,
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                (decimal max, decimal min, bool onMax) = ExtraFunctions.LoadPreset(dialog.FileName);

                ExtraFunctions.SetNumericUpDownValue(nupMax, max);
                ExtraFunctions.SetNumericUpDownValue(nupMin, min);
                nupMin.Enabled = isOnMax = onMax;
                nupMax.Enabled = !onMax;

                if (isOnMax && (int)AudioManager.GetMasterVolume() != nupMax.Value)
                    AudioManager.SetMasterVolume((float)nupMax.Value);
                else if (!isOnMax && (int)AudioManager.GetMasterVolume() != nupMin.Value)
                    AudioManager.SetMasterVolume((float)nupMin.Value);
            }
        }
    }
}