﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Remote_Healtcare_Console
{
    class Bike : Kettler
    {
        //private Client client;
        private SerialCommunicator serialCommunicator;
        private bool start;
        private Console console;

        public Bike(string port, Console console)
        {
            this.console = console;
            start = false;
            RecordedData = new HashSet<BikeData>();
            serialCommunicator = new SerialCommunicator(port);
        }

        public void Start()
        {
            start = true;
            serialCommunicator.OpenConnection();
            System.Threading.Thread.Sleep(1000);
            serialCommunicator.Reset();
            System.Threading.Thread.Sleep(1000);
            serialCommunicator.SetManual();
            serialCommunicator.clearBuffer();
            Run();
        }

        public void Stop()
        {
            start = false;
            serialCommunicator.CloseConnection();
        }

        public override void Reset()
        {
            serialCommunicator.Reset();
            RecordedData.Clear();
        }

        public override void Run()
        {
            while(serialCommunicator.IsConnected() && start)
            {
                Update();
                System.Threading.Thread.Sleep(500);
            }
        }

        public override void SetAscending()
        {
            serialCommunicator.SetCountForward();
        }

        public override void SetDescending()
        {
            serialCommunicator.SetCountDownwards();
        }

        public override void SetResistance(int resistance)
        {
            serialCommunicator.SetResistance(resistance);
        }

        public override void SetTime(int mm, int ss)
        {
            serialCommunicator.SetTime(mm, ss);
        }

        public override void SetDistance(int distance)
        {
            serialCommunicator.SetDistance(distance);
        }

        public override void Update()
        {
            string data = serialCommunicator.Status(this);
            string[] dataSplitted = data.Split(' ');

            if (RecordedData.Count > 1)
            {
                RecordedData.Add(new BikeData(int.Parse(dataSplitted[0]), int.Parse(dataSplitted[1]), dataSplitted[2], int.Parse(dataSplitted[3]),
                    int.Parse(dataSplitted[4]), int.Parse(dataSplitted[5]), dataSplitted[6], int.Parse(dataSplitted[7])));
                System.Console.WriteLine(GetLatestBikeData().ToString());
                serialCommunicator.clearBuffer();
            }
            else
            {
                RecordedData.Add(new BikeData(int.Parse(dataSplitted[0]), int.Parse(dataSplitted[1]), dataSplitted[2], int.Parse(dataSplitted[3]),
                    int.Parse(dataSplitted[4]), int.Parse(dataSplitted[5]), dataSplitted[6], int.Parse(dataSplitted[7])));
                System.Console.WriteLine(GetLatestBikeData().ToString());
                serialCommunicator.clearBuffer();
            }

            SetDataToGUI();
        }

        public int getRecordedDataSize()
        {
            return RecordedData.Count;
        }

        public override void SetDataToGUI()
        {
            BikeData bikeData = GetLatestBikeData();

            try
            {
                console.Invoke((MethodInvoker)delegate {
                    // Running on the UI thread
                    console.SetPulse(bikeData.Pulse.ToString());
                    console.SetRoundMin(bikeData.Rpm.ToString());
                    console.SetSpeed(bikeData.Speed.ToString());
                    console.SetDistance(bikeData.Distance.ToString());
                    console.SetResistance(bikeData.Resistance.ToString());
                    console.SetEnergy(bikeData.Energy.ToString());
                    console.SetTime(((bikeData.Time < TimeSpan.Zero) ? "-" : "") + bikeData.Time.ToString(@"mm\:ss"));
                    console.SetWatt(bikeData.Power.ToString());
                });
            }
            catch (System.InvalidOperationException) { }
            catch (System.ComponentModel.InvalidAsynchronousStateException) { }
        }

        public override BikeData GetLatestBikeData()
        {
            return RecordedData.Last();
        }
    }
}
