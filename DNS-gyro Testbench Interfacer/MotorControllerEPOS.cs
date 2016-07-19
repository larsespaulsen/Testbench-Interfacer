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
using EposCmd.Net;
using EposCmd.Net.DeviceCmdSet.Operation;

namespace DNS_gyro_Testbench_Interfacer
{  

    class MotorControllerEPOS
    {
       
        private DeviceManager _mConnector;
        private Device _mEpos;
        public uint errorCode = 0;//TODO

        public bool initializeNewMotorController(UInt16 DeviceNr)
        {try{
                if (_mConnector != null)
                {
                    /*                    
                     * Important notice:
                     * It's recommended to call the Dispose function before application close 
                     */
                    _mConnector.Dispose();
                }

                _mConnector = new DeviceManager();

                //get baudrate info
                uint b = _mConnector.Baudrate;

                //set connection properties
                _mConnector.Baudrate = b;
                _mConnector.Timeout = 500;
                
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
                //MessageBox.Show("yo");
                

                _mEpos = _mConnector.CreateDevice(DeviceNr);

                string textBoxAOM = _mEpos.Operation.OperationMode.GetOperationModeAsString();


                

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

        public void setMotorControllerVelocityAndAccelleration(UInt32 velocity, UInt32 acceleration, UInt32 deacceleration)
        {
            try
            {
                ProfilePositionMode ppm = _mEpos.Operation.ProfilePositionMode;

                ppm.ActivateProfilePositionMode();
                ppm.SetPositionProfile(velocity,acceleration,deacceleration);
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
            int tries = 0;
            ProfilePositionMode ppm = _mEpos.Operation.ProfilePositionMode;
            ppm.ActivateProfilePositionMode();

            ppm.MoveToPosition(target, true, true);
            //while(_mEpos.Operation.MotionInfo.GetPositionIs()-100<target && _mEpos.Operation.MotionInfo.GetPositionIs() + 100 > target)
            //{
            //    tries++;
            //}
            //Thread.Sleep(2000);
            
            //ppm.MoveToPosition(_mEpos.Operation.MotionInfo.GetPositionIs(), true, true);
        }


        public void absoluteMoveToAndStop(int target, UInt32 velocity, UInt32 acceleration, UInt32 deacceleration)
        {
            StateMachine sm = _mEpos.Operation.StateMachine;

            if (sm.GetFaultState())
                sm.ClearFault();

            sm.SetEnableState();

            int tries = 0;

            ProfilePositionMode ppm = _mEpos.Operation.ProfilePositionMode;
            ppm.ActivateProfilePositionMode();
            ppm.SetPositionProfile(velocity, acceleration, deacceleration);
            ppm.MoveToPosition(target, true, true);

            Thread.Sleep(1500);

            sm = _mEpos.Operation.StateMachine;

            if (sm.GetFaultState())
                sm.ClearFault();

            sm.SetDisableState();
            //ppm.MoveToPosition(_mEpos.Operation.MotionInfo.GetPositionIs(), true, true);
        }


    }
}
