using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TerraformLauncherApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnRunTerraform_Click(object sender, EventArgs e)
        {
            // Disable the button while Terraform commands are running
            btnRunTerraform.Enabled = false;

            // Run Terraform init and apply asynchronously
            await RunTerraformAsync();

            // Enable the button after Terraform commands are completed
            btnRunTerraform.Enabled = true;
        }

        private async Task RunTerraformAsync()
        {
            // Assuming the Terraform script is in C:\Temp folder
            string terraformScriptDirectory = @"C:\Temp\Terraform\Script";

            // Run 'terraform init' command
            await RunCommandAsync("terraform", "init", terraformScriptDirectory);

            // Run 'terraform apply' command
            await RunCommandAsync("terraform", "apply", terraformScriptDirectory);
        }

        private async Task RunCommandAsync(string command, string arguments, string workingDirectory)
        {
            using (Process process = new Process())
            {
                process.StartInfo.FileName = command;
                process.StartInfo.Arguments = arguments;
                process.StartInfo.WorkingDirectory = workingDirectory;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;

                // Handle output data
                process.OutputDataReceived += (sender, e) =>
                {
                    if (!string.IsNullOrEmpty(e.Data))
                    {
                        // You can handle the output data as needed (e.g., log it, display it, etc.)
                        Console.WriteLine(e.Data);
                    }
                };

                // Start the process
                process.Start();

                // Begin asynchronous read of the output stream
                process.BeginOutputReadLine();

                // Wait for the process to exit
                await process.WaitForExitAsync();
            }
        }
    }
    public static class ProcessExtensions
    {
        public static Task<int> WaitForExitAsync(this Process process)
        {
            var tcs = new TaskCompletionSource<int>();
            process.EnableRaisingEvents = true;
            process.Exited += (sender, args) => tcs.TrySetResult(process.ExitCode);
            return tcs.Task;
        }
    }
}
