﻿using Org.BouncyCastle.Utilities;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace server
{
    namespace Types
    {
        namespace ClientSend
        {
            struct CLIENT_SEND_PACKET_HEADER
            {
                public int RequestId;
                public int PacketSize;
            };

            [StructLayout(LayoutKind.Sequential)]
            public unsafe struct PACKET_CLIENT_HARDWARE_INFORMATION
            {
                public fixed char MotherboardSerialNumber[32];
                public fixed char DeviceDriver0Serial[32];
            }
        }

        namespace ClientReport
        {
            [StructLayout(LayoutKind.Sequential)]
            public unsafe struct MODULE_VERIFICATION_CHECKSUM_FAILURE
            {
                public int ReportCode;
                public UInt64 ModuleBaseAddress;
                public UInt64 ModuleSize;
                public fixed char ModuleName[512];
            }

            public struct PROCESS_THREAD_START_FAILURE
            {
                public int ReportCode;
                public long ThreadId;
                public UInt64 StartAddress;
            }

            public struct PAGE_PROTECTION_FAILURE
            {
                public int ReportCode;
                public UInt64 PageBaseAddress;
                public long AllocationProtection;
                public long AllocationState;
                public long AllocationType;
            }

            public struct PATTERN_SCAN_FAILURE
            {
                public int ReportCode;
                public int SignatureId;
                public UInt64 Address;
            }

            public struct NMI_CALLBACK_FAILURE
            {
                public int ReportCode;
                public int WereNmisDisabled;
                public UInt64 KThreadAddress;
                public UInt64 InvalidRip;
            }

            [StructLayout(LayoutKind.Sequential)]
            public unsafe struct MODULE_VALIDATION_FAILURE
            {
                public int ReportCode;
                public int ReportType;
                public long DriverBaseAddress;
                public long DriverSize;
                public fixed char ModuleName[128];
            }

            [StructLayout(LayoutKind.Sequential)]
            public unsafe struct OPEN_HANDLE_FAILURE_REPORT
            {
                public int ReportCode;
                public int IsKernelHandle;
                public uint ProcessId;
                public uint ThreadId;
                public uint DesiredAccess;
                public fixed char ProcessName[64];

            }
        }
    }
}
