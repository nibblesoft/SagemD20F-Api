﻿using System;

namespace HackSagemRouter.Models
{
    public enum Flags
    {
        None,
        Complete,
        Incomplete
    }

    /// <summary>
    /// ARP (The address resolution protocol) table devices.
    /// </summary>
    public class DeviceInfo
    {
        public DeviceInfo(string hostname, string macAddress, string ipAddress, Flags flags, DateTime expiresIn)
        {
            Hostname = hostname;
            MacAddress = macAddress;
            IpAddress = ipAddress;
            ExpiresIn = expiresIn;
            Flags = flags;
        }

        /// <summary>
        /// Hostname of the client.
        /// </summary>
        public string Hostname { get; }
        /// <summary>
        /// Mac address of the client.
        /// </summary>
        public string MacAddress { get; }
        /// <summary>
        /// IP address of the client.
        /// </summary>
        public string IpAddress { get; }
        /// <summary>
        /// Expiry date of the current IP address
        /// </summary>
        public DateTime ExpiresIn { get; }
        public Flags Flags { get; set; }
    }
}
