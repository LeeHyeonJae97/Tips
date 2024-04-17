using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using UnityEngine;

public class WindowCommandPrompt : MonoBehaviour
{
    public static void Run()
    {
        // create process
        Process process = new Process();

        // set settings for process
        process.StartInfo = new ProcessStartInfo()
        {
            // process name to run
            FileName = "cmd.exe",
            // set 'false' to redirect input, output and error
            UseShellExecute = false,
            // redirect to input by script
            RedirectStandardInput = true,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            // hide window
            CreateNoWindow = true,
        };

        // start process
        process.Start();

        StreamWriter sw = process.StandardInput;

        // input any command to use
        sw.WriteLine("--- command ---");

        // input exit command
        sw.WriteLine("exit");

        // wait until exit from process and quit
        process.WaitForExit();
        process.Close();
    }

    public static void Run2()
    {
        // NOTE :
        // Start의 인자로 명령어 '/k' 혹은 '/c'를 앞에 붙여 전달해야 정상적으로 수행된다.
        // '/k'의 경우 명령어를 수행한 뒤 대기하고 '/c'의 경우 명령어를 수행한 뒤 Command 프로그램을 종료한다.
        //
        Process.Start("cmd.exe", "/k --- command ---");
    }
}
