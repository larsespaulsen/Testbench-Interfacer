using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Threading;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Timers;
using System.Globalization;
using System.Collections;
using System.IO;
using System.Runtime.InteropServices;
using EposPCmd.Net;
using EposPCmd.Net.DriveCmdSet.Operation;

namespace DNS_gyro_Testbench_Interfacer

{

    class MotorControllerEPOSP
    {

        private MotorControllerEPOS motor = new MotorControllerEPOS();

        private DeviceManager _mConnector;
        private Gateway _mGateway;
        private Drive _mEposp;
        public uint errorCode = 0;//TODO

        public bool initializeNewMotorController(UInt16 DeviceNr)
        {
            string deviceName = " ";
            string protocolStackName = " ";
            string interfaceName = " ";
            string portName = " ";
            EDialogMode dialogMode = new EDialogMode();
            try
            {
                if (_mConnector != null)
                {
                    /*                    
                     * Important notice:
                     * It's recommended to call the Dispose function before application close 
                     */
                    _mConnector.Dispose();
                }
                //_mConnector = new DeviceManager();
                //public static DeviceManager Find(ref string deviceName, ref string protocolStackName, ref string interfaceName, ref string portName, EDialogMode dialogMode);
                _mConnector = DeviceManager.Find(ref deviceName, ref protocolStackName, ref interfaceName, ref portName, dialogMode);
                MessageBox.Show("devicename: "+ deviceName + "\nprotocolStackName: " + protocolStackName + "\ninterfaceName: " + interfaceName
                    + "\n portname: " + portName + "\n dialogMode" + dialogMode);
                _mConnector = new DeviceManager();
                _mGateway = _mConnector.CreateGateway();

                motor.initializeNewMotorController(1);


            }
            catch (DeviceException e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

            try
            {
                //const string deviceName;
                
                //_mConnector.FindDrive(ref deviceName, 0);
                //MessageBox.Show(deviceName);
                //_mEposp = _mConnector.CreateDrive(deviceName);
                //MessageBox.Show("here");

                //string textBoxAOM = _mEposp.Operation.OperationMode.GetOperationModeAsString();
                //MessageBox.Show(textBoxAOM);
                //StateMachine sm = _mEposp.Operation.StateMachine;

                //if (sm.GetFaultState())
                //    sm.ClearFault();

                //sm.SetEnableState();


            }
            catch (DeviceException e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            catch (AccessViolationException e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            return true;
        }

        public void setMotorControllerVelocityAndAccelleration(UInt32 velocity, UInt32 acceleration)
        {
            try
            {
                ProfilePositionMode ppm = _mEposp.Operation.ProfilePositionMode;

                ppm.ActivateProfilePositionMode();
                ppm.SetPositionProfile(velocity, acceleration, acceleration);
            }
            catch (Exception ex)
            {
                if (ex is DeviceException || ex is OverflowException)
                {
                    MessageBox.Show("Failed to update Velocity and Acceleration.\nRead manual for valid values.");
                }
                else if (ex is InvalidOperationException)
                {
                    MessageBox.Show("Invalid Operation.");
                }
                else if (ex is FormatException)
                {
                    MessageBox.Show("Invalid formating.");
                }
                else
                {
                    throw;
                }
            }
        }

        public void absoluteMoveTo(int target)
        {
            ProfilePositionMode ppm = _mEposp.Operation.ProfilePositionMode;
            ppm.ActivateProfilePositionMode();

            ppm.MoveToPosition(target, true, true);
        }
    }
}
