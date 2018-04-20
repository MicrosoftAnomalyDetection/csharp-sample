﻿using Newtonsoft.Json;
using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AnomalyDetection
{
    public partial class Form1 : Form
    {
        private string _dataFile = "request.json";
        private Request _request;

        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.subscriptionKey.Text))
            {
                this.requestData.Text = "Please specify subscription key.";
                return;
            }
            if (string.IsNullOrEmpty(this.requestData.Text))
            {
                this.requestData.Text = "Please input request data.";
                return;
            }
            if (string.IsNullOrEmpty(this.urlBox.Text))
            {
                this.requestData.Text = "Please input url.";
                return;
            }

            var client = new AnomalyDetectionClient();
            try
            {
                var url = this.urlBox.Text;
                var match = Regex.Match(url, "(?<BaseAddress>https?://[^/]+)(?<Url>/*.+)");
                if (match.Success)
                {
                    this.responseData.Clear();
                    SetRequestData();
                    var res = await client.Request(
                        match.Groups["BaseAddress"].Value,
                        match.Groups["Url"].Value,
                        this.subscriptionKey.Text,
                        this.requestData.Text);

                    var response = JsonConvert.DeserializeObject<Response>(res);
                    this.responseData.Text = JsonConvert.SerializeObject(response, Formatting.Indented);
                    this.responseData.Text += "\n========== Response Evaluation ==========\n";
                    this.responseData.Text += "\nUsing the response to do anything you need.\n";
                    this.responseData.Text += "\n========== Evaluation Done ==========\n";
                }
                else
                {
                    this.responseData.Text = "Incorrect endpoint.";
                }

            }
            catch (Exception ex)
            {
                this.responseData.Text = ex.ToString();
            }
        }

        private void SetRequestData()
        {
            this.requestData.Text = JsonConvert.SerializeObject(this._request, Formatting.Indented);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.dataFile.Text = _dataFile;
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader(_dataFile))
                {
                    // Read the stream to a string, and write the string to the console.
                    String requestData = sr.ReadToEnd();
                    _request = JsonConvert.DeserializeObject<Request>(requestData);
                    this.period.Text = _request.Period.ToString();
                    SetRequestData();
                }
            }
            catch (Exception ex)
            {
                this.responseData.Text += $"Could not build request: {ex.ToString()}";
            }
        }

        private void period_TextChanged(object sender, EventArgs e)
        {
            if (_request != null)
            {
                float v = 0;
                this.period.ForeColor = System.Drawing.Color.White;
                if (float.TryParse(this.period.Text, out v))
                {
                    this._request.Period = v;
                    this.period.BackColor = System.Drawing.Color.Green;
                } else
                {
                    this.period.BackColor = System.Drawing.Color.Red;
                }
                SetRequestData();
            }
        }
    }
}
