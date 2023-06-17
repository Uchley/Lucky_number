using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using Android.Widget;
using System;

namespace Lucky_Number
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        SeekBar seekBar;
        TextView resultTextView;
        Button rollButton;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_main);
            seekBar = FindViewById<SeekBar>(Resource.Id.seekBar);
            resultTextView = FindViewById<TextView>(Resource.Id.resultTextView);
            resultTextView.Text = "5";
            rollButton = (Button)FindViewById(Resource.Id.rollButton);
            rollButton.Click += RollButton_Click;

        }

        private void RollButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int luckyNumber = random.Next(seekBar.Progress) + 1;
            resultTextView.Text = luckyNumber.ToString();
        }
    }
}